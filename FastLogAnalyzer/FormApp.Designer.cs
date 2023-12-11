namespace FastLogAnalyzer
{
    partial class FormApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.groupBoxSelectLog = new System.Windows.Forms.GroupBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFails = new System.Windows.Forms.Label();
            this.buttonSelectLog = new System.Windows.Forms.Button();
            this.comboBoxFails = new System.Windows.Forms.ComboBox();
            this.labelRow = new System.Windows.Forms.Label();
            this.textBoxNRows = new System.Windows.Forms.TextBox();
            this.textBoxAddressLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelTrackId = new System.Windows.Forms.Label();
            this.labelTrackIdNumber = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.textBoxFail = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDeveloped = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSelectLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSelectLog
            // 
            this.groupBoxSelectLog.Controls.Add(this.labelAddress);
            this.groupBoxSelectLog.Controls.Add(this.labelFails);
            this.groupBoxSelectLog.Controls.Add(this.buttonSelectLog);
            this.groupBoxSelectLog.Controls.Add(this.comboBoxFails);
            this.groupBoxSelectLog.Controls.Add(this.labelRow);
            this.groupBoxSelectLog.Controls.Add(this.textBoxNRows);
            this.groupBoxSelectLog.Controls.Add(this.textBoxAddressLog);
            this.groupBoxSelectLog.Location = new System.Drawing.Point(2, 81);
            this.groupBoxSelectLog.Name = "groupBoxSelectLog";
            this.groupBoxSelectLog.Size = new System.Drawing.Size(250, 170);
            this.groupBoxSelectLog.TabIndex = 0;
            this.groupBoxSelectLog.TabStop = false;
            this.groupBoxSelectLog.Text = "SelectLog";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(3, 16);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(96, 16);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Select the Log:";
            // 
            // labelFails
            // 
            this.labelFails.AutoSize = true;
            this.labelFails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFails.Location = new System.Drawing.Point(3, 67);
            this.labelFails.Name = "labelFails";
            this.labelFails.Size = new System.Drawing.Size(59, 16);
            this.labelFails.TabIndex = 6;
            this.labelFails.Text = "Failures:";
            // 
            // buttonSelectLog
            // 
            this.buttonSelectLog.Location = new System.Drawing.Point(204, 32);
            this.buttonSelectLog.Name = "buttonSelectLog";
            this.buttonSelectLog.Size = new System.Drawing.Size(40, 23);
            this.buttonSelectLog.TabIndex = 4;
            this.buttonSelectLog.Text = "...";
            this.buttonSelectLog.UseVisualStyleBackColor = true;
            this.buttonSelectLog.Click += new System.EventHandler(this.buttonSelectLog_Click);
            // 
            // comboBoxFails
            // 
            this.comboBoxFails.BackColor = System.Drawing.Color.White;
            this.comboBoxFails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFails.Enabled = false;
            this.comboBoxFails.FormattingEnabled = true;
            this.comboBoxFails.Location = new System.Drawing.Point(6, 86);
            this.comboBoxFails.Name = "comboBoxFails";
            this.comboBoxFails.Size = new System.Drawing.Size(238, 21);
            this.comboBoxFails.TabIndex = 3;
            this.comboBoxFails.SelectedIndexChanged += new System.EventHandler(this.comboBoxFails_SelectedIndexChanged);
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRow.Location = new System.Drawing.Point(74, 126);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(42, 16);
            this.labelRow.TabIndex = 2;
            this.labelRow.Text = "Rows";
            // 
            // textBoxNRows
            // 
            this.textBoxNRows.BackColor = System.Drawing.Color.White;
            this.textBoxNRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNRows.Location = new System.Drawing.Point(6, 123);
            this.textBoxNRows.Name = "textBoxNRows";
            this.textBoxNRows.Size = new System.Drawing.Size(62, 22);
            this.textBoxNRows.TabIndex = 1;
            this.textBoxNRows.Text = "20";
            this.textBoxNRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAddressLog
            // 
            this.textBoxAddressLog.BackColor = System.Drawing.Color.White;
            this.textBoxAddressLog.Location = new System.Drawing.Point(6, 35);
            this.textBoxAddressLog.Name = "textBoxAddressLog";
            this.textBoxAddressLog.ReadOnly = true;
            this.textBoxAddressLog.Size = new System.Drawing.Size(192, 20);
            this.textBoxAddressLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fast Log Analyzer";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.White;
            this.textBoxResult.Location = new System.Drawing.Point(258, 88);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(738, 466);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.White;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(8, 470);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(244, 80);
            this.textBoxStatus.TabIndex = 3;
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackId.Location = new System.Drawing.Point(4, 266);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(73, 20);
            this.labelTrackId.TabIndex = 4;
            this.labelTrackId.Text = "Track ID:";
            // 
            // labelTrackIdNumber
            // 
            this.labelTrackIdNumber.AutoSize = true;
            this.labelTrackIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackIdNumber.Location = new System.Drawing.Point(81, 266);
            this.labelTrackIdNumber.Name = "labelTrackIdNumber";
            this.labelTrackIdNumber.Size = new System.Drawing.Size(0, 20);
            this.labelTrackIdNumber.TabIndex = 5;
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFail.Location = new System.Drawing.Point(4, 300);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(122, 20);
            this.labelFail.TabIndex = 6;
            this.labelFail.Text = "Fail Description:";
            // 
            // textBoxFail
            // 
            this.textBoxFail.BackColor = System.Drawing.Color.White;
            this.textBoxFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFail.Location = new System.Drawing.Point(8, 323);
            this.textBoxFail.Multiline = true;
            this.textBoxFail.Name = "textBoxFail";
            this.textBoxFail.ReadOnly = true;
            this.textBoxFail.Size = new System.Drawing.Size(244, 103);
            this.textBoxFail.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(4, 448);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 20);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status:";
            // 
            // labelDeveloped
            // 
            this.labelDeveloped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDeveloped.AutoSize = true;
            this.labelDeveloped.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic);
            this.labelDeveloped.Location = new System.Drawing.Point(5, 552);
            this.labelDeveloped.Name = "labelDeveloped";
            this.labelDeveloped.Size = new System.Drawing.Size(187, 13);
            this.labelDeveloped.TabIndex = 10;
            this.labelDeveloped.Text = "Developed by Arquimedes M. / R. Kelin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FastLogAnalyzer.Properties.Resources.flex;
            this.pictureBox1.Location = new System.Drawing.Point(889, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 566);
            this.Controls.Add(this.labelDeveloped);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxFail);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelTrackIdNumber);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxSelectLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 605);
            this.Name = "FormApp";
            this.Text = "Fast Log Analyzer v0.1";
            this.groupBoxSelectLog.ResumeLayout(false);
            this.groupBoxSelectLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectLog;
        private System.Windows.Forms.Button buttonSelectLog;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBoxAddressLog;
        private System.Windows.Forms.Label labelTrackId;
        private System.Windows.Forms.Label labelFail;
        public System.Windows.Forms.TextBox textBoxFail;
        public System.Windows.Forms.ComboBox comboBoxFails;
        private System.Windows.Forms.Label labelFails;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAddress;
        public System.Windows.Forms.TextBox textBoxNRows;
        public System.Windows.Forms.TextBox textBoxResult;
        public System.Windows.Forms.Label labelTrackIdNumber;
        public System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDeveloped;
    }
}

