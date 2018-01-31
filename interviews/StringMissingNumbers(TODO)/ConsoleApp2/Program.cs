using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Notes for task:
    1) Looking for object oriented design, break down by components, abstraction, etc
    2) Design approach for production code
    3) Unit-tests are necessary


    You are given a sorted list of distinct integers from 0 to 99, for instance[0, 1, 2, 50, 52, 75]. Your task is to produce a string that describes numbers missing from the list; in this case "3-49,51,53-74,76-99". 

Examples: 


[] “0-99” 
[0] “1-99” 
[3, 5] “0-2,4,6-99”
*/
namespace Excluder
{
    public static class Excluder
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int[] input = inputStr.Split(',').;



        }

        public static string Exclude(int[] input)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    result += input[i] - 1 + "," + input[i] + 1;
                }
                else if (input[i] > 1)
                {
                    result += "1";
                }

                if (i + 1 < input.Length)
                {
                    if (input[i] + 1 < input[i + 1])
                    {
                        result += "-";
                    }
                    else
                    {
                        result += ",";
                    }

                }

                if (i + 1 == input.Length)
                {
                    if (input[i] != 99)
                    {
                        result += "99";
                    }
                    else
                    {
                        result += "98";
                    }
                }

            }
        }

    }
}