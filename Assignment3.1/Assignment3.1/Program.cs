using System;
using System.Linq;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Marks:");
            int[] marks = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter mark {i+1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            int sum = marks.Sum();

            Console.WriteLine("Sum of Entered Marks is {0}", sum);
            Console.ReadKey();
        }
    }
}