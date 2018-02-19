using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BingTestTask
{
    public static class CsvDuplicateReader
    {
        /*
         * GetDuplicatesFromSortedFile
         * print duplicates if data in the file was sorted (as was in provided example)
         */
        public static string GetDuplicatesFromSortedFile(StreamReader file, string columnName)
        {
            StringBuilder result = new StringBuilder();
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

            if (indColumn < 0)
            {
                throw new ArgumentException("Column doesn't exist");

            }

            result.AppendLine(firstLine);
            for (int i = 0; i <= indColumn; i++)
            {
                colNum += firstLine[i] == ',' ? 1 : 0;
            }

            string str = string.Empty, prev = file.ReadLine();
            int countDupl = 0;
            while ((str = file.ReadLine()) != null && prev != null)
            {
                string cell = str.Split(',')[colNum];
                if (cell == prev.Split(',')[colNum])
                {
                    if (countDupl == 0)
                    {
                        result.AppendLine(prev);
                    }

                    countDupl++;
                    prev = str;
                    result.AppendLine(str);
                }
                else
                {
                    prev = str;
                    countDupl = 0;
                }

            }

            return result.ToString();
        }

        /*
         * GetDuplicates
         * print duplicates from file without sorting, using collections
         */

        public static string GetDuplicates(StreamReader file, string columnName)
        {
            StringBuilder result = new StringBuilder();
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

            if (indColumn < 0)
            {
                throw new ArgumentException("Column doesn't exist");

            }
            result.AppendLine(firstLine);

            for (int i = 0; i <= indColumn; i++)
            {
                colNum += firstLine[i] == ',' ? 1 : 0;
            }

            string str = string.Empty;
            Dictionary<string, string> data = new Dictionary<string, string>();
            while ((str = file.ReadLine()) != null)
            {
                string key = str.Split(',')[colNum];
                if (data.ContainsKey(key))
                {
                    if (data[key] != string.Empty)
                    {
                        result.AppendLine(data[key]);
                    }

                    result.AppendLine(str);
                    data[key] = string.Empty;
                }
                else
                {
                    data.Add(key, str);
                }
            }


            return result.ToString();
        }

    }
}