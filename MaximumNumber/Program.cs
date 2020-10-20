using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find Maximum number Program! ");
            Console.WriteLine("Enter 3 integers");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int i3 = int.Parse(Console.ReadLine());
            int output = FindMaxNumber.MaximumIntegerNumber(i1, i2, i3);
            Console.WriteLine("Maximum Integer among " + i1 + "," + i2 + "," + i3 + " : " + output);
        }
    }
}
