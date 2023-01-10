using LineComparision;
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose Option\n 1.Length Of A Line\t 2.Equality of two lines\t 3.CompareLength\t 4.Comparing lines Using OOPs concept");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LineComparisionComputation.CalculateLength();
                    break;
                case 2:
                    EqualityOfTwoLines.Equality();
                    break;
                case 3:
                    CompareLengthOFTwoLines.CompareLength();
                    break;
                case 4:
                    LineComparisionUsingOOPs obj = new LineComparisionUsingOOPs();
                    obj.SetLength1(3, 4, 7, 8);
                    obj.GetLength1();
                    obj.SetLength2(3, 4, 5, 8);
                    obj.GetLength2();
                    obj.display1();
                    obj.display2();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
            }
        }
    }

}