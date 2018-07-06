using System;
using System.IO;
using System.Text;

public class GFG
{
    static public void Main()
    {
        ///https://www.geeksforgeeks.org/stock-buy-sell/
        ///Stock Buy Sell to Maximize Profit
        ///The cost of a stock on each day is given in an array, find the max profit that you can make by buying and selling in those days. 
        ///For example, if the given array is {100, 180, 260, 310, 40, 535, 695}, the maximum profit can earned by buying on day 0, selling on day 3. 
        ///Again buy on day 4 and sell on day 6. If the given array of prices is sorted in decreasing order, then profit cannot be earned at all.

        int n = int.Parse(ReadLine());
        int[][] arrArr = new int[n][];
        for (int j = 0; j < n; j++)
        {
            Console.ReadLine();
            string[] arrStr = ReadLine().Split(' ');
            arrArr[j] = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arrArr[j][i] = int.Parse(arrStr[i]);
            }
        }
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(StockBuySell(arrArr[j]));
        }
        Console.ReadKey();
    }

    // method to increase console input length
    private static string ReadLine()
    {
        Stream inputStream = Console.OpenStandardInput(5000);
        byte[] bytes = new byte[5000];
        int outputLength = inputStream.Read(bytes, 0, 5000);
        //Console.WriteLine(outputLength);
        char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
        return new string(chars);
    }
    public static string StockBuySell(int[] arr)
    {
        string result = string.Empty;

        if (arr == null || arr.Length == 0)
        {
            return "";
        }
        int curr = 0, diff;
        bool buy = true;

        for (int i = 0; i < arr.Length; i++)
        {
            diff = arr[i] - arr[curr];
            if (diff > 0)
            {
                if (buy)
                {
                    result += "(" + curr + " ";
                    buy = false;
                }
            }
            if (diff < 0)
            {
                if (!buy)
                {
                    result += curr + ") ";
                    buy = true;
                }
            }
            if (i == arr.Length - 1)
            {
                if (!buy)
                {
                    result += i + ")";
                    buy = true;
                }
            }
            curr = i;
        }
        return result.TrimEnd();
    }
}