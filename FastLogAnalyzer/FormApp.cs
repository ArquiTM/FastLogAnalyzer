using System;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    public partial class FormApp : Form
    {
        private static FormApp INSTANCE = null;
        SelectLog SL;
        ReadLog RL;
        string logTemp = string.Empty;

        public FormApp()
        {
            InitializeComponent();
            INSTANCE = this;
            createDirectory();
            classesInit();
        }     
        private void createDirectory()
        {
            textBoxStatus.Text = Environment.NewLine + "Waiting Select Log...";
            Application.DoEvents();

            if (!Directory.Exists("temp"))
                Directory.CreateDirectory("temp");
        }

        private void classesInit()
        {
            SL = new SelectLog();
            RL = new ReadLog();
        }

        public static FormApp getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormApp();

            return INSTANCE;
        }

        private void buttonSelectLog_Click(object sender, EventArgs e)
        {
            string response = SL.SelectingLog();

            if (response != "" && SL.Extract(response))
            {
                labelTrackIdNumber.Text = response.Substring(0, 10);
                reader(response);
            }

            if (textBoxAddressLog.Text != "")
                comboBoxFails.Enabled = true;
        }

        private void reader(string Folder)
        {
            string sDir = @".\temp\" + Folder + @"\prod\log\";
            string filePath = string.Empty;
            foreach (string f in Directory.GetFiles(sDir))
            {
                if (!f.Contains("startup") && f.Contains(".log"))
                    filePath = f;
            }

            logTemp = SL.AddingReaderToLog(filePath);
            if (RL.FillingComboBox(logTemp))
                textBoxStatus.Text = Environment.NewLine + "File Imported Successfully!!!";
        }

        private void comboBoxFails_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            RL.ShowErrorOnTextBox(logTemp);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you would like to exit?", "Close the program", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
            if (Directory.Exists("temp"))
                Directory.Delete("temp", true);
        }
    }
}