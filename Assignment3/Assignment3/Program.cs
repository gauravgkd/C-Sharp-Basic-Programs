//Write a program to accept 5 marks from the user and calculate their sum using Console Application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int sum = a + b + c + d + e;
            Console.WriteLine("Sum of Entered Marks is {0} ",sum);
            Console.ReadKey();

        }
    }
}
