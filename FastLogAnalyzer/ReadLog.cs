using System;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    class ReadLog
    {
        FormApp frmMain = FormApp.getInstance();
        int rows = 1;
        public void FillingComboBox(string filePath)
        {

            string line = string.Empty;
            using (var reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    rows++;
                    if (line.Contains("* FAILED *"))
                    {
                        string[] error = line.Split('\t');
                        frmMain.comboBoxFails.Items.Add(error[9]);
                    }
                }
            }
        }

        public void ShowErrorOnTextBox(string filePath)
        {
            string[] line = new string[rows];
            int i = 0;
            int rowsTx = int.Parse(frmMain.textBoxNRows.Text);

            using (var reader = new StreamReader(filePath))
            {
                while ((line[i] = reader.ReadLine()) != null && frmMain.textBoxResult.Text == "")
                {
                    if (line[i].Contains(frmMain.comboBoxFails.Text))
                    {

                        int startRow = i - rowsTx;

                        for (int j = startRow; j <= i; j++)
                        {
                            //  string[] newLine = new string;

                            frmMain.textBoxResult.Text += line[j].Substring(36) + Environment.NewLine;
                            Application.DoEvents();
                        }
                    }
                    i++;
                }
            }
        }
    }
}

