using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = File.OpenText("..\\..\\data.csv"))
            {
                string asd = CsvDuplicateReader.GetDuplicates(file, "column1");
            }

        }
    }
}
