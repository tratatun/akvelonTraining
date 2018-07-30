using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsInSentence
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int numSentence = GetBiggestSentence(str);

            Console.WriteLine(numSentence);
            Console.ReadKey();
        }

        public static int GetBiggestSentence(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("Wrong Input");
            }
            char[] separators = { '.', '?', '!' };
            int words = 0, sentenceNumber = -1, currentWords = 0, currentSentenceNumber = 0;
            bool wordStarted = false;

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]>=48 && str[i]<=57 || 
                    str[i]>=65 && str[i]<=90 || 
                    str[i]>=97 && str[i] <= 122)
                {
                    if (!wordStarted)
                    {
                        wordStarted = true;
                        currentWords++;
                    }
                }
                else
                {
                    wordStarted = false;
                }

                if (separators.Contains(str[i]) || i == str.Length - 1)
                {
                    if (words < currentWords)
                    {
                        sentenceNumber = currentSentenceNumber;
                        words = currentWords;
                    }

                    if (currentWords > 0)
                    {
                        currentSentenceNumber++;
                        currentWords = 0;
                    }
                }
            }
            return sentenceNumber;
        }


    }
}
