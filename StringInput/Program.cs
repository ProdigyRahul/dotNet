using System;
namespace StringInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string var1 = Console.ReadLine();
            string[] words = var1.Split();

            for (int i = 0; i < words.Length; i++)
            {
                if (i == words.Length - 1)
                {
                    Console.WriteLine($"'{words[i]}'");
                }
                else
                {
                    Console.Write($"'{words[i]}', ");
                }
            }
        }
    }
}
