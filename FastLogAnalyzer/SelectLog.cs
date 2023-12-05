using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    class SelectLog
    {
        FormApp frmMain = FormApp.getInstance();
        string fileName;
        string destFile;

        public string SelectingLog()
        {
            try
            {
                frmMain.openFileDialog1.Filter = "All files (*.*)|*.*";
                if (frmMain.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = frmMain.openFileDialog1.FileName;
                    frmMain.textBoxAddressLog.Text = fileName;

                    string fileNameLog = fileName.Replace(@"\\jagnt092\NexTestFailureLogsCAR", "");
                    destFile = @".\temp\" + fileNameLog;

                    File.Copy(fileName, destFile, true);

                    string[] trackId = fileNameLog.Split('_');
                    string temp = trackId[0];
                    temp = temp.Replace("\\", "");

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

        public bool Extract()
        {
            try
            {
                string zipPath = destFile;
                string extractPath = @".\temp\";

                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                {
                    archive.ExtractToDirectory(extractPath);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e.Message);
                return false;
            }
        }
    }
}
