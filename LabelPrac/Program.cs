using System;

namespace LabelPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

        start:
            Console.WriteLine("Enter two numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 10 || num2 > 10)
            {
                Console.WriteLine("Both numbers must be 10 or lesser. Please try again.");
                goto start;
            }
            else
            {
                Console.WriteLine("Number 1 : " + num1);
                Console.WriteLine("Number 2 : " + num2);
            }

            Console.WriteLine("This Program is written by Rahul Mistry");
        }
    }
}
