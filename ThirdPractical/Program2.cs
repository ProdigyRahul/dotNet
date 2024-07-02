using System;

namespace ThirdPractical
{
    class Program2
    {
        static void Main(string[] args)
        {
            int num1, num2;

            while (true)
            {
                Console.WriteLine("Enter two numbers: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 >= 10 && num2 >= 10)
                {
                    break;
                }

                Console.WriteLine("Both numbers must be 10 or greater. Please try again.");
            }

            // Print the result
            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
            // Print the author's name
            Console.WriteLine("This Program is written by Rahul Mistry");
        }
    }
}
