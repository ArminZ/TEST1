﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AirNavigationRaceLive.Dialogs
{
    public partial class ParticipantDialog : Form
    {
       // private DataAccess Client;
        public int selectedIdx;
        public EventHandler OnFinish;
        public ParticipantDialog(List<string> lstTKOFLineNames)
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = lstTKOFLineNames;
           // comboBoxTKOFLines.DataSource = bs;
        }

        

        public void UpdateEnablement()
        {
            //btnOK.Enabled = comboBoxTKOFLines.SelectedItem != null;
        }

        private void btnUploadData_Click(object sender, EventArgs e)
        {
            //if (comboBoxTKOFLines.SelectedItem != null)
            //{
            //    OnFinish.Invoke(null, null);
            //    Close();
            //}
          //  selectedIdx = comboBoxTKOFLines.SelectedIndex;
            Close();
        }
    }
}
