using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasTree
{
    class Program
    {
        static int height =10;
        static void Main(string[] args)
        {
            Console.WriteLine("*".PadLeft(height));
            for (int i = height; i > 0; i--)
            {
                Console.Write("0".PadLeft(i));
                for (int j = 0; j < (2*height) - (2 * i); j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
