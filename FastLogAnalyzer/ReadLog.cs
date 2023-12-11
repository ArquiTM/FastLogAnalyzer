using System;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    class ReadLog
    {
        FormApp frmMain = FormApp.getInstance();
        int rows = 1;

        public bool FillingComboBox(string filePath)
        {
            try
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
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ShowErrorOnTextBox() method: " + e.Message);
                return false;
            }
        }

        public void ShowErrorOnTextBox(string filePath)
        {
            try
            {
                frmMain.textBoxStatus.Text = Environment.NewLine + "Filling Lines...";
                string[] line = new string[rows];
                int i = 0;
                int rowsTx = int.Parse(frmMain.textBoxNRows.Text);

                using (var reader = new StreamReader(filePath))
                {
                    while ((line[i] = reader.ReadLine()) != null && frmMain.textBoxResult.Text == "")
                    {
                        if (line[i].Contains(frmMain.comboBoxFails.Text))
                        {
                            i++;
                            line[i] = reader.ReadLine();
                            int startRow = i - rowsTx - 1;

                            for (int j = startRow; j <= i; j++)
                            {
                                string[] newLine = line[j].Split('\t');

                                for (int y = 0; y < 5; y++)
                                {
                                    line[j] = line[j].Replace("\t\t", "\t");
                                    line[j] = line[j].Replace(newLine[y] + '\t', "");
                                }
                                frmMain.textBoxResult.Text += line[j] + Environment.NewLine;
                                Application.DoEvents();
                            }
                        }
                        i++;
                    }
                }
                frmMain.textBoxStatus.Text = Environment.NewLine + "Completed!!!";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ShowErrorOnTextBox() method: " + e.Message);
            }
        }
    }
}

