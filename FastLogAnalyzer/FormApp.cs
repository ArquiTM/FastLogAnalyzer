using System;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    public partial class FormApp : Form
    {
        private static FormApp INSTANCE = null;
        SelectLog SL;


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
                textBoxStatus.Text = "File Imported Successfully!!!";
        }
    }
}
