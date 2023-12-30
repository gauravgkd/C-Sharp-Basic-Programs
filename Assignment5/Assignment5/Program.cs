// Write a program to swap two variables using a third variable by Console Application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine("The Number Before Swapping {0}",a);
            Console.WriteLine("The Number Before Swapping {0}", b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("The Number After Swapping {0}", a);
            Console.WriteLine("The Number After Swapping {0}", b);
            Console.ReadKey();
        }
    }
}
