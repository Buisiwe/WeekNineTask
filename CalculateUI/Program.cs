using System;
using CalculateLibrary;
using System.Collections;
using System.Collections.Generic;


namespace CalculateUI
{
    class Program
    {
        static void Main(string[] args)
        { 
        try{

            
            //Creating a list that will store inputs from user
            List<string> calculations = new List<string>();
            //Adding different fuction items to calculations list 
            calculations.Add("Sum");
            calculations.Add("Difference");
            calculations.Add("Product");
            calculations.Add("Quotient");
            calculations.Add("SqaureRoot");



            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Calculator Program");
            Console.WriteLine("..............................................................................................");
            //Prompting user to enter 2 inputs to find sum then display results
            Console.WriteLine("Let's Sum two numbers!");
            Console.Write("Enter a number:    ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:    ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int summmg = Calculator.Sum(n1, n2);
            Console.WriteLine("\nThe sum  is : {0} \n", summmg);
            Console.WriteLine("..............................................................................................");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Prompting user to enter 2 inputs to find difference then display results
            Console.WriteLine("Let's find the difference of two numbers");
            Console.Write("Enter a number:    ");
            int nu1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:    ");
            int nu2 = Convert.ToInt32(Console.ReadLine());
            int dif = Calculator.Difference(nu1, nu2);
            Console.WriteLine("\nThe difference is : {0} \n", dif);
            Console.WriteLine("..............................................................................................");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //Prompting user to enter 2 inputs to find product then display results
            Console.WriteLine("Let's find the product of two numbers!");
            Console.Write("Enter a number:    ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:    ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int pro = Calculator.Product(num1, num2);
            Console.WriteLine("\nThe product is : {0} \n",pro );
            Console.WriteLine("..............................................................................................");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Prompting user to enter 2 inputs to find how many times goes and the reminder then display results
            Console.WriteLine("Let's find the quotient of two numbers!");
            Console.Write("Enter a number:    ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:    ");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            int number = Math.DivRem(numb1, numb2, out int tot);
            int qua =Calculator.Quotient(numb1, numb2);
            Console.WriteLine("\nIt goes: " + " " + (number) + " time(s) " + "    the reminder is : {0}", qua);
            Console.WriteLine("..............................................................................................");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Prompting user to enter an input to find square root then display results
            Console.WriteLine("Let's find the square root of any number!");
            Console.Write("Enter a number:    ");
            double numbr1 = Convert.ToDouble(Console.ReadLine());
            double sqr = Calculator.SquareRoot(numbr1);
            Console.WriteLine("\nThe square root  is : {0} \n",sqr);

            //Prompting user to enter Y for Yes or  N for No, if user wants to see calculation history then display results
            Console.Write("Would you like to see your History? Y/N:    ");
            string answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (answer == "Y" || answer == "y")
            {
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("This is your calculation history");
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("Functionality : " + calculations[0].ToString());
                Console.WriteLine("First number entered is : " + n1 + " Second number entered is: " + n2);
                Console.WriteLine("Output was " + summmg);
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("Functionality : " + calculations[1].ToString());
                Console.WriteLine("First number entered is : " + nu1 + " Second number entered is: " + nu2);
                Console.WriteLine("Output was " + dif);
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("Functionality : " + calculations[2].ToString());
                Console.WriteLine("First number entered is : " + num1 + " Second number entered is: " + num2);
                Console.WriteLine("Output was " + pro);
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("Functionality : " + calculations[3].ToString());
                Console.WriteLine("First number entered is : " + numb1 + " Second number entered is: " + numb2);
                Console.WriteLine("Output was  " + number + " reminder is " + qua);
                Console.WriteLine("___________________________________________________________________________________________");
                Console.WriteLine("Functionality : " + calculations[4].ToString());
                Console.WriteLine("The squared number entered is : " + numbr1);
                Console.WriteLine("Output was " + sqr);
                Console.WriteLine("The End.....................................................................................");
            }
            else
            {
                Console.WriteLine("Enjoy Your Day!!!!!");
            }

                Console.WriteLine("BYEEEEE!!!!");
            }
            //Catches erors that might be thrown while program is running
            catch(FormatException)
            {
                Console.WriteLine("Not a valid format.Please try again.");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Error occured!Please try again.");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Please try again!");
                Console.ReadLine();
            }
        

        }
    }
}

