using System;
using System.Diagnostics.CodeAnalysis;

namespace Perfect_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please,enter the starting number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please, enter the end number ");
            int endnum= int.Parse(Console.ReadLine());

            Console.WriteLine("Perfect numbers from " + num1 + " to " + endnum + ": ");
            for (int i = num1 ; i <= endnum; i++)
            {
                if (perfectnum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
         public static bool perfectnum (int n)
        {
            int sum = 0;
            for (int j = 1; j < n; j++)
            {
                if (n % j== 0)
                {
                    sum += j;
                }
            }
            return sum == n;
        }
    }
}
