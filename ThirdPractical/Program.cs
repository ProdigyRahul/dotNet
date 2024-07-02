using System.Reflection.Emit;

namespace ThirdPractical
{
    class Program {
        static void Main(string[] args)
        {
            int var1, var2, var3;
            Console.WriteLine("Enter first number: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            var3 = Convert.ToInt32(Console.ReadLine());
            if (var1 > var2 && var1 > var3)
                Console.WriteLine("The largest number is: " + var1);
            else if (var2 > var1 && var2 > var3)
                Console.WriteLine("The largest number is: " + var2);
            else
                Console.WriteLine("The largest number is: " + var3);
            Console.WriteLine("This Program is written by Rahul Mistry");
        }
    }
}