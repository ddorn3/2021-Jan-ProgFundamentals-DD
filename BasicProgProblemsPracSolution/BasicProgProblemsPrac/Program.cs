using System;

namespace BasicProgProblemsPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.  West Coast Company
            //declare constant and variables
            //Assign value to totalSales
            //Calculate totalSalesofSalesUnit; totalSales*(SalesUnitPercentage/100.0)
            //Display calculated value

            //double SalesUnitPercentage = 43.0;
            //double totalSales = 5.3;
            //double totalSalesofSalesUnit = totalSales * (SalesUnitPercentage / 100.0);

            //Console.WriteLine($"If West Coast has {totalSales} million dollars in total sales, it will generate ${totalSalesofSalesUnit} million dollars.");


            //2. Land Calculator
            //Program
            //Declare constant and variables
            //Prompt user for size of land tract
            //Read user input
            //Convert user input into a numeric variable
            //Calculate number of acres: land tract size / acre size
            //Display calculated value

            int AcreSize=43560;
            Console.Write("Enter a value in square feet to calculate the number of acres:\t");
            string inputTemp = Console.ReadLine();
            double landTractSize = double.Parse(inputTemp);
            double numberOfAcres = landTractSize / AcreSize;
            Console.WriteLine($"The number of acres is {numberOfAcres}");
















        }
    }
}
