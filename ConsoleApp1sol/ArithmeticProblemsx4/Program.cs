using System;

namespace ArithmeticProblemsx4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arithmetic Problems - 4 Quesitions 
            // Use operators and equations
            //  
            // Author:  David Dorn
            // Jan 21, 2021

            // first math problem

            Console.WriteLine("Hello Human, you are going to enter 3 numbers.");
            Console.WriteLine("After the 3rd number is entered I will use my power to show you the average.");
            Console.WriteLine("Enter the first number:  ");

            //string inputFirstNumber = Console.ReadLine();

            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the second number:  ");

            string inputSecondNumber = Console.ReadLine();

            double number2 = double.Parse(inputSecondNumber);

            Console.WriteLine("\nEnter the last number:  ");

            string inputLastNumber = Console.ReadLine();

            double number3 = double.Parse(inputLastNumber);

            double averageCalculation = (number1 + number2 + number3) / 3;

            Console.WriteLine($"The average of {number1} and {number2} and {number3} is:  {averageCalculation,2}");

            Console.WriteLine("Thanks for playing");


            //second math problem

            //Console.WriteLine("Hello Human, you are going to enter 3 numbers.");
            //Console.WriteLine("After the 3rd number is entered I will use my power to show you the average.");
            //Console.WriteLine("\nEnter the first number:  ");

            //string inputFirstNumber = Console.ReadLine();

            //double number1 = double.Parse(inputFirstNumber);

            //Console.WriteLine("\nEnter the second number:  ");

            //string inputSecondNumber = Console.ReadLine();

            //double number2 = double.Parse(inputSecondNumber);

            //Console.WriteLine("\nEnter the last number:  ");

            //string inputLastNumber = Console.ReadLine();

            //double number3 = double.Parse(inputLastNumber);

            //double averageCalculation = (number1 + number2 + number3) / 3;

            //averageCalculation = Math.Round(averageCalculation, 2);

            //Console.WriteLine ($"\nThe average of {number1} and {number2} and {number3} is:  {averageCalculation,2}");

            //Console.WriteLine("\nThanks for playing");




            // third math problem




            // fourth math problem


            //Console.WriteLine("Please enter a 3-digit whole number - NO DECIMALS Okay? ");

            //int number = int.Parse(Console.ReadLine());
            //int sum = 0, reminder;

            //while (number > 0)
            //{
            //    reminder = number % 10;
            //    sum = sum + reminder;
            //    number = number / 10;
            //}

            //Console.WriteLine($"The Sum of Digits is : {sum}");

















        }
    }
}
