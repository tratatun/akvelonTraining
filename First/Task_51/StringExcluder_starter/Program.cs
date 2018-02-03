using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcluder_starter
{
    public class Program
    {
        /*
         * 51. Given two strings S1 and S2. Delete from S2 all those characters which occur in S1 also and finally
           create a clean S2 with the relevant characters deleted.
         */
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine(TrivialExludeCharacters_ExtraSpace(s1, s2));
            Console.ReadKey();
        }

        public static string TrivialExludeCharacters_ExtraSpace(string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                throw new ArgumentException("Wrong Input");
            }

            if (s1 == string.Empty)
            {
                return s2;
            }

            int i = 0, j = 0;
            int[] ind = new int[s2.Length];
            StringBuilder result = new StringBuilder();
            while (i < s1.Length && j < s2.Length)
            {
                if (s1[i] == s2[j])
                {
                    ind[j] = -1;
                }

                if (i == s1.Length - 1)
                {
                    i = 0;
                    j++;
                }
                else
                {
                    i++;
                }
            }

            for (int k = 0; k < ind.Length; k++)
            {
                if (ind[k] == 0)
                {
                    result.Append(s2[k]);
                }
            }

            return result.ToString();
        }

        public static string TrivialExludeCharacters_WithoutExtraSpace(string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                throw new ArgumentException("Wrong Input");
            }

            if (s1 == string.Empty)
            {
                return s2;
            }

            int i = s1.Length - 1, j = s2.Length - 1;
            StringBuilder result = new StringBuilder(s2);
            while (i >= 0 && j >= 0)
            {
                if (s1[i] == s2[j])
                {
                    result.Remove(j, 1);
                }

                if (i == 0)
                {
                    i = s1.Length - 1;
                    j--;
                }
                else
                {
                    i--;
                }
            }

            return result.ToString();
        }
    }
}
