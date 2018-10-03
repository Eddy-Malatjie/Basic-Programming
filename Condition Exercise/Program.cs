using System;

namespace Iteration_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Condition Cond = new Condition();
           
            Console.WriteLine("//Find largest number among 3 numbers");

            Console.WriteLine("Please enter the 1st number!");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd number!");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 3rd number!");
            int num3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The largest number is {0}", Cond.FindTheLargest(num1, num2, num3));
            //*******************************************************

            Console.WriteLine("//Find second largest number among 3 numbers ");

            Console.WriteLine("Please enter the 1st number!");
            int num4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd number!");
            int num5 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 3rd number!");
            int num6 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The second largest number is {0}",Cond.FindTheSecondLargest(num4, num5, num6));
            
            //********************************************************
            int[] sevenNums = new int[7];
            Console.WriteLine("//Find largest number among 7 numbers");
            
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Please enter the number {0}!",i+1);
                sevenNums[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("The Largest number is {0}",Cond.FindTheLargest(sevenNums));

            //*******************************************************
            Console.WriteLine("//Print numbers from 1 to N, But if the number");
            Console.WriteLine("//is multiple of 3 then print "+"FIZZ"+" and if the");
            Console.WriteLine("//number is multiple of 5 then print "+"BUZZ"+".");
            Console.WriteLine("//But if the number is multiple of both 3 and 5");
            Console.WriteLine("//then print only "+"FIZZBUZZ"+".");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of numbers you want");
            int nNum = Int32.Parse(Console.ReadLine());
            Cond.FizzBuzz(nNum);

            //*******************************************************
            Console.WriteLine("//Check if a number is negative, positive or zero.");
            Console.WriteLine("Please enter any number to check if it's negative, positive or zero!");
            int num = Int32.Parse(Console.ReadLine());
            Cond.PositiveNegativeZeroCheck(num);

            //*******************************************************
            Console.WriteLine("//Check if a number is even or odd");
            Console.WriteLine("Please enter any number to check if it is even or odd!");
            int number = Int32.Parse(Console.ReadLine());
            Cond.EvenOddCheck(number);
            //*******************************************************
            Console.WriteLine("//Check if a year is leap year or not");
            int year= Int32.Parse(Console.ReadLine());

            if(Cond.IsLeapYear(year))
            {
                Console.WriteLine("The year you entered is a leap year");
            }
            else
            {
                Console.WriteLine("The year you entered is not a leap year");
            }
                       
            Console.ReadKey();
        }
    }
}
