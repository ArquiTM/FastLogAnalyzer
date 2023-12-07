using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    class ReadLog
    {
        FormApp frmMain = FormApp.getInstance();

        /* public void FileToVet(string strFilePath)
         {
             int countRow = 0;
             string line = string.Empty;

             using (var reader = new StreamReader(strFilePath))
             {
                 int i = 0;
                 countRow = strFilePath.Length;
                 string[] vet = new string[countRow];
                 while ((line = reader.ReadLine()) != null && i < countRow)
                 {
                     line = reader.ReadLine();
                     vet[i] = line;
                     i++;
                 }
                 for (int j = 0; j < vet.Length; j++)
                 {
                     if (vet[j].Contains("* FAILED *"))
                         frmMain.comboBoxFails.
                  }
             }

         }*/

        public DataTable ConvertToDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split('\t');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split('\t');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}

