using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcluder
{
    public static class StringExcluder
    {
        public static string TrivialExludeCharacters(string exclude, string target)
        {
            for (int i = 0; i < exclude.Length; i++)
            {
                target = target.Replace(exclude[i].ToString(), "");
            }
            return target;
        }


    }
}
