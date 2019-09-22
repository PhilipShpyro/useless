using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string word = Console.ReadLine();
                int count = 0, maxCount = 0;
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] == word[i + 1])
                    {
                        count++;
                        if (count > maxCount)
                            maxCount = count;
                    }
                    else
                        count = 0;
                }
                Console.WriteLine(++maxCount);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}