using System;
using static System.Console;

namespace MethodMadnessCont
{
    class Program
    {
        static void Main(string[] args)
        {
            


            //changing using a reference
            double squareLength = 4;
            WriteLine("The length of a side of the square is {0}", squareLength);
            SquareArea(ref squareLength);
            WriteLine("The area of the square is {0}", squareLength);




            //changes using an 'out' reference
            double squareLengthA = 5;
            double areaA;

            WriteLine("The length of a side of the square is {0}", squareLengthA);
            string size = SquareArea(squareLengthA, out areaA);
            WriteLine("The area of the square with a side length of {0} is {1}", squareLengthA, areaA);
            WriteLine("This square is {0}", size);

            //changes using a standard method return from chapter 7
            double squareLengthB = 7;
            WriteLine("The length of a side of the square is {0}", squareLengthB);
            double areaB = SquareArea(squareLengthB);
            WriteLine("The area of the square with a side length of {0} is {1}", squareLengthB, areaB);

        }

        //method that squares using a reference
        private static void SquareArea(ref double Length)
        {
            Length *= Length;
        }

        //method squares using 'out' reference and returns opinion on size
        private static string SquareArea(double Length, out double Area)
        {
            Area = Length * Length;

            if(Area > 20)
            {
                return "BIG";
            }
            else
            {
                return "small";
            }
        }

        private static double SquareArea(double Length)
        {
            double area = Length * Length;

            return area;
        }

    }
}
