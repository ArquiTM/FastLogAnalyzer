using System.IO;
namespace FastLogAnalyzer
{
    class ReadLog
    {
        FormApp frmMain = FormApp.getInstance();

        public void FillingComboBox(string filePath)
        {
            string line = string.Empty;
            using (var reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("* FAILED *"))
                    {
                        string[] error = line.Split('\t');
                        frmMain.comboBoxFails.Items.Add(error[9]);
                    }
                }
            }
        }
    }
}

