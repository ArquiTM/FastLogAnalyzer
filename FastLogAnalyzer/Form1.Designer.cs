namespace FastLogAnalyzer
{
    partial class Form1
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
            this.groupBoxSelectLog = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSelectLog = new System.Windows.Forms.Button();
            this.comboBoxFails = new System.Windows.Forms.ComboBox();
            this.labelRow = new System.Windows.Forms.Label();
            this.textBoxNRows = new System.Windows.Forms.TextBox();
            this.textBoxAddressLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxSelectLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelectLog
            // 
            this.groupBoxSelectLog.Controls.Add(this.buttonUpdate);
            this.groupBoxSelectLog.Controls.Add(this.buttonSelectLog);
            this.groupBoxSelectLog.Controls.Add(this.comboBoxFails);
            this.groupBoxSelectLog.Controls.Add(this.labelRow);
            this.groupBoxSelectLog.Controls.Add(this.textBoxNRows);
            this.groupBoxSelectLog.Controls.Add(this.textBoxAddressLog);
            this.groupBoxSelectLog.Location = new System.Drawing.Point(23, 88);
            this.groupBoxSelectLog.Name = "groupBoxSelectLog";
            this.groupBoxSelectLog.Size = new System.Drawing.Size(229, 163);
            this.groupBoxSelectLog.TabIndex = 0;
            this.groupBoxSelectLog.TabStop = false;
            this.groupBoxSelectLog.Text = "SelectLog";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(154, 128);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSelectLog
            // 
            this.buttonSelectLog.Location = new System.Drawing.Point(183, 31);
            this.buttonSelectLog.Name = "buttonSelectLog";
            this.buttonSelectLog.Size = new System.Drawing.Size(40, 23);
            this.buttonSelectLog.TabIndex = 4;
            this.buttonSelectLog.Text = "...";
            this.buttonSelectLog.UseVisualStyleBackColor = true;
            // 
            // comboBoxFails
            // 
            this.comboBoxFails.FormattingEnabled = true;
            this.comboBoxFails.Location = new System.Drawing.Point(5, 70);
            this.comboBoxFails.Name = "comboBoxFails";
            this.comboBoxFails.Size = new System.Drawing.Size(172, 21);
            this.comboBoxFails.TabIndex = 3;
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Location = new System.Drawing.Point(74, 104);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(34, 13);
            this.labelRow.TabIndex = 2;
            this.labelRow.Text = "Rows";
            // 
            // textBoxNRows
            // 
            this.textBoxNRows.Location = new System.Drawing.Point(6, 101);
            this.textBoxNRows.Name = "textBoxNRows";
            this.textBoxNRows.Size = new System.Drawing.Size(62, 20);
            this.textBoxNRows.TabIndex = 1;
            // 
            // textBoxAddressLog
            // 
            this.textBoxAddressLog.Location = new System.Drawing.Point(6, 33);
            this.textBoxAddressLog.Name = "textBoxAddressLog";
            this.textBoxAddressLog.Size = new System.Drawing.Size(171, 20);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(883, 466);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 566);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxSelectLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSelectLog.ResumeLayout(false);
            this.groupBoxSelectLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectLog;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSelectLog;
        private System.Windows.Forms.ComboBox comboBoxFails;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.TextBox textBoxNRows;
        private System.Windows.Forms.TextBox textBoxAddressLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

