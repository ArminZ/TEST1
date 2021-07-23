﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using AirNavigationRaceLive.Client;
using AirNavigationRaceLive.Comps.Helper;
using AirNavigationRaceLive.Model;

namespace AirNavigationRaceLive.Dialogs
{
    public partial class UploadGAC : Form
    {
        private DataAccess Client;
        private FlightSet ct;

        public EventHandler OnFinish;
        public UploadGAC(DataAccess Client, FlightSet ct)
        {
            this.Client = Client;
            this.ct = ct;
            InitializeComponent();
            dateGAC.Enabled = false;

        }

        private void btnImportGAC_Click(object sender, EventArgs e)
        {
            textBoxPositions.Text = String.Empty;
            textBoxPositions.Tag = null;
            OpenFileDialog ofd = new OpenFileDialog();
            string FileFilter = "GAC and IGC files  (*.gac, *.igc)|*.gac;*.igc";
            ofd.Title = "GAC Import";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;
            ofd.Filter = FileFilter;
            ofd.FileOk += new CancelEventHandler(ofd_FileOk);
            ofd.ShowDialog();
        }

        void ofd_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = sender as OpenFileDialog;
            try
            {
                string dt = string.Empty;
                string WarningText = String.Empty;
                DateTime? CompDate0 = new DateTime();
                DateTime? CompFirstTime0 = new DateTime();
                DateTime CompDate = new DateTime();
                bool isValidDate = Importer.GACFileHasValidDate(ofd.FileName, out CompDate0, out CompFirstTime0);
                dateGAC.Text = String.IsNullOrEmpty(CompDate0.ToString()) ? String.Empty : ((DateTime)CompDate0).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                btnUploadData.Visible = isValidDate;


                // the normal case
                if (isValidDate && CompDate0 != null && CompFirstTime0 != null && ((DateTime)CompDate0) >= new DateTime(2005, 12, 31))
                {
                    // combined date + time
                    CompDate = ((DateTime)CompDate0).Add(((DateTime)CompFirstTime0).TimeOfDay);
                    dateGAC.Text = CompDate.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
                    btnUploadData.Visible = true;
                }

                // date in GAC file line 2 is formally valid, but older than 2005-12-31
                // this date threshold is selected based on experience  - in the ANR competition in Portugal (date was March 2004) 
                if (isValidDate && CompDate0 != null && CompFirstTime0 != null && ((DateTime)CompDate0) < new DateTime(2005, 12, 31))
                {
                    string res = "The date {0} (given as '{1}') is formally valid, but may be outdated/incorrect.";
                    string strCompDate = ((DateTime)CompDate0).ToString("ddMMyy");
                    res = string.Format(res,
                                ((DateTime)CompDate0).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                                 strCompDate
                                );
                    res = string.Join("\n", res) + "\nIf required, correct the date(default: original date, format: ddMMyy):";
                    if (InputBoxClass.InputBox("Check Date", res, ref strCompDate) == DialogResult.OK)
                    {
                        CompDate0 = DateTime.ParseExact(strCompDate, "ddMMyy", CultureInfo.InvariantCulture);
                        CompDate = ((DateTime)CompDate0).Add(((DateTime)CompFirstTime0).TimeOfDay);
                        dateGAC.Text = CompDate.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
                        btnUploadData.Visible = true;
                    }
                }

                // invalid date in GAC file line 2
                if (!(isValidDate) && CompFirstTime0 != null)
                {
                    string res = string.Join("\n", Importer.lstWarnings) + "\nDefine the correct date (default: actual date):";
                    string strCompDate = DateTime.Today.ToString("ddMMyy");
                    if (InputBoxClass.InputBox("Invalid Date", res, ref strCompDate) == DialogResult.OK)
                    {
                        CompDate0 = DateTime.ParseExact(strCompDate, "ddMMyy", CultureInfo.InvariantCulture);
                        CompDate = ((DateTime)CompDate0).Add(((DateTime)CompFirstTime0).TimeOfDay);
                        dateGAC.Text = CompDate.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
                        btnUploadData.Visible = true;
                    }
                }

                List<Point> list = Importer.GPSdataFromGAC(ofd.FileName, CompDate);

                textBoxPositions.Text = list.Count.ToString();
                textBoxPositions.Tag = list;
                if (Importer.lstWarnings.Count > 0)
                {
                    string res = string.Join("\n", Importer.lstWarnings);
                    MessageBox.Show(res, "Import warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.ToString(), "Error while Parsing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateGAC.Text = string.Empty;
                return;
            }
            UpdateEnablement();
        }
        public void UpdateEnablement()
        {
            btnUploadData.Enabled = textBoxPositions.Tag != null && !String.IsNullOrEmpty(dateGAC.Text);
        }

        private void btnUploadData_Click(object sender, EventArgs e)
        {
            double C_CORR_HRS = (double)numericUpDownTimeCorrectionHrs.Value;

            if (textBoxPositions.Tag != null && textBoxPositions.Text != "0")
            {
                List<Point> list = textBoxPositions.Tag as List<Point>;
                Client.DBContext.Point.RemoveRange(ct.Point);
                foreach (Point point in list)
                {
                    if (C_CORR_HRS > 0.0)
                    {
                        // we add here a potential hour shift correction 
                        // NOTE: point.Timestamp is in Ticks
                        // use a Timespan and add x hours
                        // convert back to ticks (using the ticks property of the timespan)
                        TimeSpan ts = new TimeSpan(point.Timestamp);
                        ts += TimeSpan.FromHours(C_CORR_HRS);
                        point.Timestamp = ts.Ticks;
                    }
                    ct.Point.Add(point);
                }
                Client.DBContext.SaveChanges();
                GeneratePenalty.CalculateAndPersistPenaltyPoints(Client, ct);
                OnFinish.Invoke(null, null);
                Close();
            }
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    dateGAC.Text = dateTimePicker1.Value.ToShortDateString();
        //}
    }
}
