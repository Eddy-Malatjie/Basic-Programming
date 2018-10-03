using System;

namespace Iteration_Exercise
{
    class Condition
    {
        public int FindTheLargest(int num1, int num2, int num3)
        {
            int largestNum = num1;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    largestNum = num1;
                }
                else
                {
                    largestNum = num3;
                }

            }
            else if (num2 > num3)
            {
                largestNum = num2;
            }
            else
            {
                largestNum = num3;
            }

            return largestNum;
        }
        public int FindTheSecondLargest(int num1, int num2, int num3)
        {
            int secondLargest = 0;

            if (num1 > num2 && num1 > num3)

                if (num2 > num3)
                {
                    secondLargest = num2;
                }
                else
                {
                    secondLargest = num3;
                }
            if (num2 > num1 && num2 > num3)

                if (num1 > num3)
                {
                    secondLargest = num1;
                }
                else
                {
                    secondLargest = num3;
                }
            if (num3 > num1 && num3 > num2)

                if (num2 > num1)
                {
                    secondLargest = num2;
                }
                else
                {
                    secondLargest = num3;
                }

            return secondLargest;
        }
        public int FindTheLargest(int[] arrOfNum)
        {
            int LargestNum = 0;
            for (int i = 0; i < arrOfNum.Length; i++)
            {
                if (arrOfNum[i] > LargestNum)
                {
                    LargestNum = arrOfNum[i];
                }
            }
            return LargestNum;
        }
        public void FizzBuzz(int nNumber)
        {
            for (int i = 1; i <= nNumber; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void PositiveNegativeZeroCheck(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            if (num < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("The Number is equal to zero");
            }
        }
        public void EvenOddCheck(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        public bool IsLeapYear(int year)
        {

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
