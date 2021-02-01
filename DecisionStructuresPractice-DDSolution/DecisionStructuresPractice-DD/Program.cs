using System;

namespace DecisionStructuresPractice_DD
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1

            // double posNegZer;
            //string inputTempNumber;

            // Console.Write("Enter a number: ");
            // inputTempNumber = Console.ReadLine();
            // posNegZer = double.Parse(inputTempNumber);

            // if (posNegZer > 0)
            // {
            //     Console.WriteLine("Your number is positive.");
            // }
            // else if (posNegZer < 0)
            // {
            //     Console.WriteLine("Your number is negative.");
            // }
            // else if (posNegZer == 0)
            // {
            //     Console.WriteLine("Your number is zero.");
            // }

            //question 2
            //int costOfAdmission;
            //string inputTempAge;

            //Console.WriteLine("We will determine the cost of admission for a movie theatre.");
            //Console.Write("Please enter your age - be honest:  ");
            //inputTempAge = Console.ReadLine();
            //costOfAdmission = int.Parse(inputTempAge);

            //if (costOfAdmission < 7)
            //{
            //    Console.WriteLine("You're a child so you're FREE");
            //}
            //else if (costOfAdmission < 18)
            //{
            //    Console.WriteLine("You're a lucky student. Pay $9.80");
            //}
            //else if (costOfAdmission < 55)
            //{
            //    Console.WriteLine("Too bad. You're an Adult. Pay $11.35");
            //}
            //else if (costOfAdmission >= 55)
            //{
            //    Console.WriteLine("That's #$%@ OLD.  Pay $10");
            //}

            //question 3

            //int mark;
            //string inputTempName;
            //string inputTempMark;

            //Console.WriteLine("We will determine your letter grade based on your mark.");
            //Console.Write("Enter your name:  ");
            //inputTempName = Console.ReadLine();
            //Console.Write("Enter your mark:  ");
            //inputTempMark = Console.ReadLine();
            //mark = int.Parse(inputTempMark);

            //if (mark < 50)
            //{
            //    Console.Write($"{inputTempName}" + ", you're a failure. Go home.\tF"); 
            //}
            //else if (mark < 70)
            //{
            //    Console.WriteLine($"{inputTempName}" + ", barely.\tD");
            //}
            //else if (mark < 80)
            //{
            //    Console.WriteLine($"{inputTempName}" + ", okay.\tC");
            //}
            //else if (mark < 90)
            //{
            //    Console.WriteLine($"{inputTempName}" + ", pretty good.\tB");
            //}
            //else if (mark <= 100)
            //{
            //    Console.WriteLine($"{inputTempName}" + ", awesome genius!\tA");
            //}

            //question 4

            int income;
            int taxOwedLow;
            int taxOwedMed;
            int taxOwedHigh;
            string inputTempIncome;
            
            Console.WriteLine("We will determine your income tax due based on your taxable income");
            Console.Write("Enter your taxable income rounded to the nearest dollar:  ");
            inputTempIncome = Console.ReadLine();
            income = int.Parse(inputTempIncome);

            if (income <= 50000)
            { taxOwedLow = (income * 5) / 100;
            
                Console.WriteLine("Tax due is:  " + $"{taxOwedLow}");
            }
            else if (income <= 100000)
            {    taxOwedMed = (2500 + ((income - 50000) * 7 / 100));
            
                Console.WriteLine("Tax due is:  " + $"{taxOwedMed}");
            }
            else if (income >= 100000)
            {    taxOwedHigh = (6000 + ((income - 100000) * 9 / 100));
            
                Console.WriteLine("Tax due is:  " + $"{taxOwedHigh}");
            }


        }
    }
}
