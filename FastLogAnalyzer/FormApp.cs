using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    public partial class FormApp : Form
    {
        private static FormApp INSTANCE = null;
        OpenLog OL;


        public FormApp()
        {
            InitializeComponent();
            INSTANCE = this;
            createDirectory();
            ClassesInit();


        }
        private void createDirectory()
        {
            Directory.CreateDirectory("temp");
        }
        private void ClassesInit()
        {
            OL = new OpenLog();
        }
        public static FormApp getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormApp();

            return INSTANCE;
        }

        private void buttonSelectLog_Click(object sender, EventArgs e)
        {
            labelTrackIdNumber.Text = OL.selectingLog();
            textBoxStatus.Text = "File Imported Successfully!!!";
        }
    }
}
