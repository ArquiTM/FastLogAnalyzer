using System.IO;
namespace FastLogAnalyzer
{
    class ReadLog
    {
        FormApp frmMain = FormApp.getInstance();
        
        public void FillingComboBox(string filePath)
        {
            int rows = 1;
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
          //  ShowErrorOnTextBox(rows);
        }

        public void ShowErrorOnTextBox(int rowsLog)
        {
        }
    }
}

