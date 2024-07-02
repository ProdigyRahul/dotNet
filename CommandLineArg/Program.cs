using System;

namespace CommandLineArg
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = args[0];
            int n = Convert.ToInt32(args[1]);
            Console.WriteLine("String" + str);
            Console.WriteLine("Number" + n);
        }
    }
}