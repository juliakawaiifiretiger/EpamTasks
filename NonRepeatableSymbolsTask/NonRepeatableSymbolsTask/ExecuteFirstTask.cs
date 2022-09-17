using System;
using System.Collections.Generic;
using System.Linq;

namespace NonRepeatableSymbolsTask
{
    public class ExecuteFirstTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character sequence: ");
            var subsequence = Console.ReadLine().ToCharArray();

            var chars = new List<string>();
            var wordsLengthes = new List<int>();

            for (int i = 0; i < subsequence.Length; i++)
            {
                if (!chars.Any(item => item == subsequence[i].ToString()) && i != subsequence.Length - 1)
                {
                    chars.Add(subsequence[i].ToString());
                }
                else
                {
                    wordsLengthes.Add(string.Join(string.Empty, chars).Length);
                    chars = new List<string>();
                    chars.Add(subsequence[i].ToString());
                } 
            }

            Console.WriteLine($"Max length: {wordsLengthes.Max()}");

            Console.ReadKey();
        }
    }
}

