﻿namespace AirNavigationRaceLive.Comps
{
    partial class UserSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkParcourAdditionalText = new System.Windows.Forms.CheckBox();
            this.chkDefaultDBDirectory = new System.Windows.Forms.CheckBox();
            this.textBoxDatabasePath = new System.Windows.Forms.TextBox();
            this.groupBoxLayer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPROHPen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownPROHAlpha = new System.Windows.Forms.NumericUpDown();
            this.btnPROHColorLayer = new System.Windows.Forms.Button();
            this.groupBoxSPFP = new System.Windows.Forms.GroupBox();
            this.chkSPFPShowCircle = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSPFPPen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSPFPColor = new System.Windows.Forms.Button();
            this.groupBoxChannel = new System.Windows.Forms.GroupBox();
            this.chkChannelShowCL = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownChannelPen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChannelColor = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHAlpha)).BeginInit();
            this.groupBoxSPFP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSPFPPen)).BeginInit();
            this.groupBoxChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelPen)).BeginInit();
            this.SuspendLayout();
            // 
            // chkParcourAdditionalText
            // 
            this.chkParcourAdditionalText.AutoSize = true;
            this.chkParcourAdditionalText.Location = new System.Drawing.Point(30, 109);
            this.chkParcourAdditionalText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkParcourAdditionalText.Name = "chkParcourAdditionalText";
            this.chkParcourAdditionalText.Size = new System.Drawing.Size(358, 24);
            this.chkParcourAdditionalText.TabIndex = 11;
            this.chkParcourAdditionalText.Text = "Parcour PDF export: Prompt for additional text";
            this.chkParcourAdditionalText.UseVisualStyleBackColor = true;
            // 
            // chkDefaultDBDirectory
            // 
            this.chkDefaultDBDirectory.AutoSize = true;
            this.chkDefaultDBDirectory.Location = new System.Drawing.Point(30, 46);
            this.chkDefaultDBDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDefaultDBDirectory.Name = "chkDefaultDBDirectory";
            this.chkDefaultDBDirectory.Size = new System.Drawing.Size(349, 24);
            this.chkDefaultDBDirectory.TabIndex = 10;
            this.chkDefaultDBDirectory.Text = "Database File: use a default DB file directory";
            this.chkDefaultDBDirectory.UseVisualStyleBackColor = true;
            // 
            // textBoxDatabasePath
            // 
            this.textBoxDatabasePath.Location = new System.Drawing.Point(427, 46);
            this.textBoxDatabasePath.Name = "textBoxDatabasePath";
            this.textBoxDatabasePath.Size = new System.Drawing.Size(503, 26);
            this.textBoxDatabasePath.TabIndex = 12;
            // 
            // groupBoxLayer
            // 
            this.groupBoxLayer.Controls.Add(this.label2);
            this.groupBoxLayer.Controls.Add(this.numericUpDownPROHPen);
            this.groupBoxLayer.Controls.Add(this.label1);
            this.groupBoxLayer.Controls.Add(this.label17);
            this.groupBoxLayer.Controls.Add(this.numericUpDownPROHAlpha);
            this.groupBoxLayer.Controls.Add(this.btnPROHColorLayer);
            this.groupBoxLayer.Location = new System.Drawing.Point(30, 179);
            this.groupBoxLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLayer.Name = "groupBoxLayer";
            this.groupBoxLayer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLayer.Size = new System.Drawing.Size(380, 145);
            this.groupBoxLayer.TabIndex = 28;
            this.groupBoxLayer.TabStop = false;
            this.groupBoxLayer.Text = "PROH Layer Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Pen Width";
            // 
            // numericUpDownPROHPen
            // 
            this.numericUpDownPROHPen.DecimalPlaces = 1;
            this.numericUpDownPROHPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPROHPen.Location = new System.Drawing.Point(7, 101);
            this.numericUpDownPROHPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPROHPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPROHPen.Name = "numericUpDownPROHPen";
            this.numericUpDownPROHPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownPROHPen.TabIndex = 29;
            this.numericUpDownPROHPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Color";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(106, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label17.Size = new System.Drawing.Size(109, 25);
            this.label17.TabIndex = 24;
            this.label17.Text = "Transparency";
            // 
            // numericUpDownPROHAlpha
            // 
            this.numericUpDownPROHAlpha.Location = new System.Drawing.Point(7, 27);
            this.numericUpDownPROHAlpha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPROHAlpha.Name = "numericUpDownPROHAlpha";
            this.numericUpDownPROHAlpha.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownPROHAlpha.TabIndex = 25;
            this.numericUpDownPROHAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPROHColorLayer
            // 
            this.btnPROHColorLayer.BackColor = System.Drawing.Color.Red;
            this.btnPROHColorLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPROHColorLayer.Location = new System.Drawing.Point(7, 63);
            this.btnPROHColorLayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPROHColorLayer.Name = "btnPROHColorLayer";
            this.btnPROHColorLayer.Size = new System.Drawing.Size(64, 28);
            this.btnPROHColorLayer.TabIndex = 26;
            this.btnPROHColorLayer.Text = "...";
            this.btnPROHColorLayer.UseVisualStyleBackColor = false;
            this.btnPROHColorLayer.Click += new System.EventHandler(this.btnPROHColorLayer_Click);
            // 
            // groupBoxSPFP
            // 
            this.groupBoxSPFP.Controls.Add(this.chkSPFPShowCircle);
            this.groupBoxSPFP.Controls.Add(this.label3);
            this.groupBoxSPFP.Controls.Add(this.numericUpDownSPFPPen);
            this.groupBoxSPFP.Controls.Add(this.label4);
            this.groupBoxSPFP.Controls.Add(this.btnSPFPColor);
            this.groupBoxSPFP.Location = new System.Drawing.Point(30, 354);
            this.groupBoxSPFP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSPFP.Name = "groupBoxSPFP";
            this.groupBoxSPFP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSPFP.Size = new System.Drawing.Size(380, 158);
            this.groupBoxSPFP.TabIndex = 29;
            this.groupBoxSPFP.TabStop = false;
            this.groupBoxSPFP.Text = "SP and FP Properties";
            // 
            // chkSPFPShowCircle
            // 
            this.chkSPFPShowCircle.AutoSize = true;
            this.chkSPFPShowCircle.Location = new System.Drawing.Point(6, 111);
            this.chkSPFPShowCircle.Name = "chkSPFPShowCircle";
            this.chkSPFPShowCircle.Size = new System.Drawing.Size(249, 24);
            this.chkSPFPShowCircle.TabIndex = 30;
            this.chkSPFPShowCircle.Text = "Show circle around SF and FP";
            this.chkSPFPShowCircle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pen Width";
            // 
            // numericUpDownSPFPPen
            // 
            this.numericUpDownSPFPPen.DecimalPlaces = 1;
            this.numericUpDownSPFPPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownSPFPPen.Location = new System.Drawing.Point(7, 31);
            this.numericUpDownSPFPPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownSPFPPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSPFPPen.Name = "numericUpDownSPFPPen";
            this.numericUpDownSPFPPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownSPFPPen.TabIndex = 26;
            this.numericUpDownSPFPPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Color";
            // 
            // btnSPFPColor
            // 
            this.btnSPFPColor.BackColor = System.Drawing.Color.Red;
            this.btnSPFPColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPFPColor.Location = new System.Drawing.Point(7, 67);
            this.btnSPFPColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSPFPColor.Name = "btnSPFPColor";
            this.btnSPFPColor.Size = new System.Drawing.Size(64, 28);
            this.btnSPFPColor.TabIndex = 29;
            this.btnSPFPColor.Text = "...";
            this.btnSPFPColor.UseVisualStyleBackColor = false;
            this.btnSPFPColor.Click += new System.EventHandler(this.btnSPFPColor_Click);
            // 
            // groupBoxChannel
            // 
            this.groupBoxChannel.Controls.Add(this.chkChannelShowCL);
            this.groupBoxChannel.Controls.Add(this.label5);
            this.groupBoxChannel.Controls.Add(this.numericUpDownChannelPen);
            this.groupBoxChannel.Controls.Add(this.label6);
            this.groupBoxChannel.Controls.Add(this.btnChannelColor);
            this.groupBoxChannel.Location = new System.Drawing.Point(30, 547);
            this.groupBoxChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxChannel.Name = "groupBoxChannel";
            this.groupBoxChannel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxChannel.Size = new System.Drawing.Size(380, 158);
            this.groupBoxChannel.TabIndex = 30;
            this.groupBoxChannel.TabStop = false;
            this.groupBoxChannel.Text = "Channel Properties";
            // 
            // chkChannelShowCL
            // 
            this.chkChannelShowCL.AutoSize = true;
            this.chkChannelShowCL.Location = new System.Drawing.Point(6, 111);
            this.chkChannelShowCL.Name = "chkChannelShowCL";
            this.chkChannelShowCL.Size = new System.Drawing.Size(151, 24);
            this.chkChannelShowCL.TabIndex = 30;
            this.chkChannelShowCL.Text = "Show Centerline";
            this.chkChannelShowCL.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pen Width";
            // 
            // numericUpDownChannelPen
            // 
            this.numericUpDownChannelPen.DecimalPlaces = 1;
            this.numericUpDownChannelPen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownChannelPen.Location = new System.Drawing.Point(7, 31);
            this.numericUpDownChannelPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownChannelPen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownChannelPen.Name = "numericUpDownChannelPen";
            this.numericUpDownChannelPen.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownChannelPen.TabIndex = 26;
            this.numericUpDownChannelPen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Color";
            // 
            // btnChannelColor
            // 
            this.btnChannelColor.BackColor = System.Drawing.Color.Red;
            this.btnChannelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChannelColor.Location = new System.Drawing.Point(7, 67);
            this.btnChannelColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChannelColor.Name = "btnChannelColor";
            this.btnChannelColor.Size = new System.Drawing.Size(64, 28);
            this.btnChannelColor.TabIndex = 29;
            this.btnChannelColor.Text = "...";
            this.btnChannelColor.UseVisualStyleBackColor = false;
            this.btnChannelColor.Click += new System.EventHandler(this.btnChannelColor_Click);
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(936, 42);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(75, 35);
            this.btnDB.TabIndex = 31;
            this.btnDB.Text = "...";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(916, 681);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 41);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(822, 681);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 41);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.groupBoxChannel);
            this.Controls.Add(this.groupBoxSPFP);
            this.Controls.Add(this.groupBoxLayer);
            this.Controls.Add(this.textBoxDatabasePath);
            this.Controls.Add(this.chkParcourAdditionalText);
            this.Controls.Add(this.chkDefaultDBDirectory);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(1094, 802);
            this.groupBoxLayer.ResumeLayout(false);
            this.groupBoxLayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPROHAlpha)).EndInit();
            this.groupBoxSPFP.ResumeLayout(false);
            this.groupBoxSPFP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSPFPPen)).EndInit();
            this.groupBoxChannel.ResumeLayout(false);
            this.groupBoxChannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannelPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkParcourAdditionalText;
        private System.Windows.Forms.CheckBox chkDefaultDBDirectory;
        private System.Windows.Forms.TextBox textBoxDatabasePath;
        private System.Windows.Forms.GroupBox groupBoxLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownPROHAlpha;
        private System.Windows.Forms.Button btnPROHColorLayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPROHPen;
        private System.Windows.Forms.GroupBox groupBoxSPFP;
        private System.Windows.Forms.CheckBox chkSPFPShowCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSPFPPen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSPFPColor;
        private System.Windows.Forms.GroupBox groupBoxChannel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownChannelPen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChannelColor;
        private System.Windows.Forms.CheckBox chkChannelShowCL;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
