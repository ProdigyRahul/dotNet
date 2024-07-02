namespace pract2{
    internal class Program{
        static void Main(string[] args){
            int var1, var2;
            Console.WriteLine("Enter Number1: ");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            var2 = Convert.ToInt32(Console.ReadLine());
            if((var1 > 10 && var2 <= 10) || (var2 > 10 && var1 <= 10)){
                Console.WriteLine("Boolean test succedded both numbers are not greater than 10");
            }
        }
    }
}