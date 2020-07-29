using System;
using System.Collections.Generic;

namespace GenericsSolo01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                printService.AddValue(value);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());


        }
    }
}
