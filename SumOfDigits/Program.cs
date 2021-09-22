using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare necessary variables
            int number, sum = 0, remainder, temp;

            //print message to show the user
            Console.Write("Please Enter a Number: ");

            //get input from user
            number = int.Parse(Console.ReadLine());

            //store it in a temp variable
            temp = number;

            //continue the program until number greater than 0
            while (number > 0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;

            }
            Console.Write("Sum of " + temp + " is " + sum);
        }
    }
}
