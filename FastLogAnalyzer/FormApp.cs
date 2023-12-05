using System;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    public partial class FormApp : Form
    {
        private static FormApp INSTANCE = null;
        SelectLog SL;
        OpenLogInExcel OLIE;


        public FormApp()
        {
            InitializeComponent();
            INSTANCE = this;
            createDirectory();
            ClassesInit();
        }
        private void createDirectory()
        {
            if (!Directory.Exists("temp"))
                Directory.CreateDirectory("temp");
        }
        private void ClassesInit()
        {
            SL = new SelectLog();
            OLIE = new OpenLogInExcel();
        }
        public static FormApp getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormApp();

            return INSTANCE;
        }

        private void buttonSelectLog_Click(object sender, EventArgs e)
        {
            labelTrackIdNumber.Text = SL.SelectingLog();

            if (labelTrackIdNumber.Text != "" && SL.Extract())
            {
                textBoxStatus.Text = "File Imported Successfully!!!";
                dataTable();
            }

            if (textBoxAddressLog.Text != "")
                comboBoxFails.Enabled = true;
        }

        private void dataTable()
        {
            string sDir = @".\temp\prod\log\";
            string filePath = string.Empty;
            foreach (string f in Directory.GetFiles(sDir))
            {
                if (!f.Contains("startup") && !f.Contains(".xml"))
                    filePath = f;
            }

            OLIE.FileToVet(filePath);
        }
    }
}
