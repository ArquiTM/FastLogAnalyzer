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
        string folderNameCommon = @".\temp\";

        public string SelectingLog()
        {
            try
            {
                frmMain.openFileDialog1.Filter = "All files (*.*)|*.*";
                if (frmMain.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    frmMain.comboBoxFails.Items.Clear();
                    frmMain.textBoxResult.Text = "";
                    DateTime dt = DateTime.Now;
                    string hour = dt.ToString("dd-MM-yy-HH_mm_ss");

                    fileName = frmMain.openFileDialog1.FileName;
                    frmMain.textBoxAddressLog.Text = fileName;

                    string[] fileNameLogLonger = fileName.Split('\\');
                    int length = fileNameLogLonger.Length;
                    string fileNameLog = fileNameLogLonger[length - 1];

                    fileNameLog = fileNameLog.Replace(".log_zip_DETAILED_MQS_FAILED", "");

                    string folderName = fileNameLog.Substring(0, 10);
                    string subFolderName = folderName + "-" + hour;
                    Directory.CreateDirectory(folderNameCommon + subFolderName);

                    destFile = folderNameCommon + subFolderName + @"\" + folderName + ".zip";
                    File.Copy(fileName, destFile, true);

                    string[] trackId = fileNameLog.Split('_');
                    string strTrackId = trackId[0];
                    int countFailed = 0;
                    string faiName = string.Empty;

                    for (int i = 0; i < trackId.Length; i++)
                    {
                        if (trackId[i].Contains("Failed"))
                            countFailed = i + 1;
                    }

                    for (int i = countFailed; i < trackId.Length - 4; i++)
                    {
                        faiName += " " + trackId[i];
                    }

                    frmMain.textBoxFail.Text = faiName;

                    return subFolderName;
                }
                return "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error SelectingLog() method: " + e.Message);
                return "";
            }
        }

        public bool Extract(string folder)
        {
            try
            {
                string zipPath = destFile;
                string extractPath = folderNameCommon + folder;

                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                {
                    archive.ExtractToDirectory(extractPath);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Extract() method: " + e.Message);
                return false;
            }
        }

        public string AddingReaderToLog(string filePath)
        {
            try
            {
                string newTempFile = filePath.Replace(".log", "_temp.log");
                string line = string.Empty;

                if (!File.Exists(newTempFile))
                    using (var writer = new StreamWriter(newTempFile))
                    {
                        using (var reader = new StreamReader(filePath))
                        {
                            writer.WriteLine("1\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12\t13\t14\t15\t16\t17\t18\t19\t20\t21\t22\t23");

                            while ((line = reader.ReadLine()) != null)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                return newTempFile;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error AddingReaderToLog() method: " + e.Message);
                return "";
            }
        }
    }
}
