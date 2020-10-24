using System;
using System.Security.Cryptography;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Class
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaxCheck<int> genericInt = new GenericMaxCheck<int>(intArray);
            Console.WriteLine("Maximum Integer : " + genericInt.MaxMethod());
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaxCheck<double> genericDouble = new GenericMaxCheck<double>(doubleArray);
            Console.WriteLine("Maximum Double  : " + genericDouble.MaxMethod());
            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMaxCheck<string> genericString = new GenericMaxCheck<string>(stringArray);
            Console.WriteLine("Maximum String  : " + genericString.MaxMethod());

            //Using Generic Method
            /*
            Console.WriteLine("Welcome to find Maximum number Program!");
            Console.WriteLine("\nEnter 3 integer Numbers");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int i3 = int.Parse(Console.ReadLine());
            FindMaxNumber.MaximumCheck<int>(i1,i2,i3);
            Console.WriteLine("\nEnter 3 float Numbers");
            float f1 = float.Parse(Console.ReadLine());
            float f2 = float.Parse(Console.ReadLine());
            float f3 = float.Parse(Console.ReadLine());
            FindMaxNumber.MaximumCheck<float>(f1,f2,f3);
            Console.WriteLine("\nEnter 3 Strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            FindMaxNumber.MaximumCheck<string>(s1,s2,s3);
            */

            //Using different methods
            /*
            Console.WriteLine("Enter 3 integer Numbers");
            int i1 = int.Parse(Console.ReadLine());
            int i2 = int.Parse(Console.ReadLine());
            int i3 = int.Parse(Console.ReadLine());
            int output1 = FindMaxNumber.MaximumIntegerNumber(i1, i2, i3);
            Console.WriteLine("Maximum Integer among " + i1 + "," + i2 + "," + i3 + " : " + output1);

            Console.WriteLine("Enter 3 float Numbers");
            float f1 = float.Parse(Console.ReadLine());
            float f2 = float.Parse(Console.ReadLine());
            float f3 = float.Parse(Console.ReadLine());
            float output2 = FindMaxNumber.MaximumFloatNumber(f1, f2, f3);
            Console.WriteLine("Maximum float number among " + f1 + "," + f2 + "," + f3 + " : " + output2);
            
            Console.WriteLine("Enter 3 Strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            string output3 = FindMaxNumber.MaximumString(s1, s2, s3);
            Console.WriteLine("Maximum String among " + s1 + ", " + s2 + ", " + s3 + " : " + output3);
            */
        }
    }
}
