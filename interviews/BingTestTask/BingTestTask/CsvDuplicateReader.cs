using System;
using System.IO;
namespace BingTestTask
{
    public static class CsvDuplicateReader
    {
        public static string[] GetDuplicatesFromSortedFile(string fileName, string columnName)
        {
            string[] result = null;
            using (StreamReader file = File.OpenText(fileName))
            {
                int indColumn = 0, colNum = 0;
                string firstLine = file.ReadLine();
                if (firstLine != null)
                {
                    indColumn = firstLine.IndexOf(columnName, StringComparison.InvariantCulture);
                }
                else
                {
                    throw new FileLoadException("File load error");
                }

                for (int i = 0; i <= indColumn; i++)
                {
                    colNum += firstLine[i] == ',' ? 1 : 0;
                }

                string s = string.Empty;
                while ((s = file.ReadLine()) != null)
                {
                    
                }
            }

            return result;
        }
    }
}