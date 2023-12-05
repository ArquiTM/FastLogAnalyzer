using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FastLogAnalyzer
{
    class OpenLogInExcel
    {
        public void FileToVet(string strFilePath)
        {
            int countRow = 0;
            string line = string.Empty;


            using (var reader = new StreamReader(strFilePath))
            {
                int i = 0;
                countRow = strFilePath.Length;
                string[] vet = new string[countRow];

                //while ((reader.ReadLine()) != null)
                //{
                //    countRow++;
                //}

                // for (int i = 0; i < countRow; i++)
                //{
                while ((line = reader.ReadLine()) != null && i < countRow)
                {

                    line = reader.ReadLine();
                    vet[i] = line;
                    i++;
                    // line = reader.ReadLine();
                }
            }
        }
    }
}

