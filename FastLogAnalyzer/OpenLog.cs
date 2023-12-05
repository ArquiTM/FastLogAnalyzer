using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    class OpenLog
    {
        FormApp frmMain = FormApp.getInstance();
        string fileName;
        public string selectingLog()
        {
            try
            {
                frmMain.openFileDialog1.Filter = "All files (*.*)|*.*";
                if (frmMain.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = frmMain.openFileDialog1.FileName;

                    string fileNameLog = fileName.Replace(@"\\jagnt092\NexTestFailureLogsCAR", "");
                    string destFile = @".\temp\" + fileNameLog;


                    File.Copy(fileName, destFile, true);

                    string[] trackId = fileNameLog.Split('_');
                    string temp = trackId[0];
                    temp = temp.Replace("\\","");
                    return temp;

                }

                return "";
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e.Message);
                return "";
            }
        }
    }
}
