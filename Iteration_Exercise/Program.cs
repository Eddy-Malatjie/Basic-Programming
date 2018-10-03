using System;

namespace Iteration_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Iteration Iter = new Iteration();
            int[] arrayOfNumbers = { 2, 11, 15, 8, 1, 7, 6, 85, 4, 11, 11, 15, 99, 100, 201, 201, 100, 321 };
            
            //Array used to test the following functions
            Console.WriteLine("Current Array: 2, 11, 15, 8, 1, 7, 6, 85, 4, 11, 11, 15, 99, 100, 201, 201, 100, 321 ");
            Console.WriteLine();

            //Find largest number from an array of numbers
            Console.WriteLine("1.Find largest number from an array of numbers ");
            Console.WriteLine("The Largest number in the array is {0}:", Iter.FindTheLargestInArray(arrayOfNumbers));

            //Find second largest number from an array of numbers
            Console.WriteLine("2.Find second largest number from an array of numbers ");
            Console.WriteLine("The second largest number in the array is {0}:", Iter.FindTheSecondInArray(arrayOfNumbers));


            //Find if a number is present in an array of numbers
            Console.WriteLine("3.Find if a number is present in an array of numbers ");
            Console.WriteLine("Please enter a number to check whether it's present in the array");
            int searchNum = Int32.Parse(Console.ReadLine());

            if (Iter.Search(arrayOfNumbers, searchNum))
            {
                Console.WriteLine("The number you entered is present");
            }
            else
            {
                Console.WriteLine("The number you entered is not present");
            }

            //Find number of occurrences of a number in an array of numbers
            Console.WriteLine("4.Find number of occurrences of a number in an array of numbers ");
            Console.WriteLine("Please enter a number to check how many times it appears in the array");
            int occNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The number occurs {0} times in the array", Iter.OccurrencesCount(arrayOfNumbers, occNum));

            //Find the number in an array of numbers with maximum occurrences
            Console.WriteLine("5.Find the number in an array of numbers with maximum occurrences ");
            Console.WriteLine("The number that appears the most in the array is {0}", Iter.MaximumOccurrences(arrayOfNumbers));

            //Find number of spaces in a sentence
            Console.WriteLine("6.Find number of spaces in a sentence ");
            Console.WriteLine("Type a sentence to find the number of spaces it has");
            string userSentenceSpaces = Console.ReadLine();
            Console.WriteLine("The sentence you entered has {0} spaces", Iter.SpaceCount(userSentenceSpaces));

            //Find number of words in a sentence
            Console.WriteLine("7.Find number of words in a sentence ");
            Console.WriteLine("Type a sentence to find the number of words it has");
            string userSentenceWords = Console.ReadLine();
            Console.WriteLine("The sentence you entered has {0} words", Iter.WordCount(userSentenceWords));

            //Replace all spaces in a sentence with underscore
            Console.WriteLine("8.Replace all spaces in a sentence with underscore ");
            string userSentenceUnderScore = Console.ReadLine();
            Console.WriteLine("Your sentence with with undescores instead of spaces: \n{0}", Iter.ReplaceSpace(userSentenceUnderScore));

            //Sort an array of numbers in ascending order
            Console.WriteLine("9.Sort an array of numbers in ascending order ");
            Console.WriteLine("Initial array:\n2, 11, 15, 8, 1, 7, 6, 85, 4, 11, 11, 15, 99, 100, 201, 201, 100, 321");
            int[] sortedArray = Iter.Sort(arrayOfNumbers);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write("{0} ", sortedArray[i]);

            }
            Console.WriteLine();
            //Find all even numbers from an array of numbers
            Console.WriteLine("10.Find all even numbers from an array of numbers ");
            Console.WriteLine("Initial array:\n2, 11, 15, 8, 1, 7, 6, 85, 4, 11, 11, 15, 99, 100, 201, 201, 100, 321");
            int[] evenNumberArray = Iter.EvenNumbers(arrayOfNumbers);
            Console.WriteLine("Even Number Array: ");
            for (int i = 0; i < evenNumberArray.Length; i++)
            {
                Console.Write("{0} ", evenNumberArray[i]);

            }
            Console.WriteLine();

            //Generate fibonacci series from 1 to N
            Console.WriteLine("11.Generate fibonacci series from 1 to N");
            Console.WriteLine("Please enter the number of numbers you want to print ");
            int nNum = Int32.Parse(Console.ReadLine());
            Iter.Fibonacci(0, 1, 1, nNum);
            Console.WriteLine();

            //Reverse a string
            Console.WriteLine("12.Reverse a string");
            Console.WriteLine("12.Please enter a string you want to reverse");
            string unReversedStr = Console.ReadLine();
            Console.WriteLine(Iter.StringReverse(unReversedStr));

            //Convert numeric string value to number like "1234"-> 1234
            Console.WriteLine("13.Convert numeric string value to number like " + "1234->" + " 1234");
            Console.WriteLine(Iter.StringToNumber("1234"));

            //Find the maximum difference between two consecutive items in an array of numbers
            Console.WriteLine("14.Find the maximum difference between two consecutive items in an array of number");
            Console.WriteLine("Current Array: 2, 11, 15, 8, 1, 7, 6, 85, 4, 11, 11, 15, 99, 100, 201, 201, 100, 321 ");
            Console.WriteLine("The maximum difference is :{0}", Iter.ConsecutiveDifference(arrayOfNumbers));

            //Count number of digits in a number
            Console.WriteLine("14.Count number of digits in a number");
            Console.WriteLine("Please enter a number with multiple digits");
            int digitsNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered has {0} digits ", Iter.DigitsCount(digitsNum));

            //Calculate sum of digits in a number
            Console.WriteLine("15.Calculate sum of digits in a number");
            Console.WriteLine("Please enter a number with multiple digits");
            int sumDigitsNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Iter.SumOfDigits(sumDigitsNum));

            //Find sum of all odd numbers between 1 to N
            Console.WriteLine("16.Find sum of all odd numbers between 1 to N");
            Console.WriteLine("Please enter the number of numbers you want to calculate the sum of odd numbers");
            int sumOddNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum is :{0} ", Iter.SumOfOddDigits(sumOddNum));

            //Swap first &last digit of a number
            Console.WriteLine("17.Swap first &last digit of a number");
            Console.WriteLine("Please enter a number with multiple digits");
            int swapNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your number with the digits swapped {0}", Iter.DigitSwap(swapNum));

            //Check if an alphabet is vowel or consonant
            Console.WriteLine("18.Check if an alphabet is vowel or consonant");
            Console.WriteLine("Please enter an alphabet ");
            char alphabet = Console.ReadKey().KeyChar;
            if (Iter.VowelCheck(alphabet))
            {
                Console.WriteLine("The alphabet is a vowel");

            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }

            //Reverse a number
            Console.WriteLine("19.Reverse a number");
            Console.WriteLine("Enter a number you want to reverse");
            int unReversedInt = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Iter.IntegerReverse(unReversedInt));

            Console.ReadKey();
        }
    }
}
