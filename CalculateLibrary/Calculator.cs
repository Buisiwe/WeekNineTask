using System;
using System.Collections;
using System.Collections.Generic;
namespace CalculateLibrary
{
    public class Calculator
    {

        //properties
        public int TheSum { get; set; }
        public int TheDifference { get; set; }
        public int TheProduct { get; set; }
        public int TheQuotient { get; set; }
        public double TheSquareRoot { get; set; }

       

        //Method that will return int data type
        public static int  Sum(int number1, int number2)
        {
            int total;
            total = number1 + number2;
            return total;

        }
        //Method that will return int data type
        public static int Difference(int number1, int number2)
        {
            int total;
            total = number1 - number2;
            return total;

        }
        //Method that will return int data type
        public static int Product(int number1, int number2)
        {
            int total;
            total = number1 * number2;
            return total;

        }
        //Method that will return int data type
        public static int Quotient(int number1, int number2)
        {
            int total;
            total = number1 % number2;
            return total;

        }
        //Method that will return double data type
        public static double SquareRoot(double number1)
        {
            double b;
            b = Math.Sqrt(number1);
            return b;

        }

        
    }
}