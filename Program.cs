﻿using LineComparision;
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose Option\n 1.Length Of A Line");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LineComparisionComputation.CalculateLength();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
        }
    }

}