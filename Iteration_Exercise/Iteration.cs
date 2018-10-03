using System;
using System.Collections;

namespace Iteration_Exercise
{
    class Iteration
    {
        public int FindTheLargestInArray(int[] arrOfNum)
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
        public int FindTheSecondInArray(int[] arrOfNum)
        {
            int LargestNum = 0;
            int largestPos = 0;
            int SecondLargestNum = 0;

            for (int i = 0; i < arrOfNum.Length; i++)
            {
                if (arrOfNum[i] > LargestNum)
                {
                    LargestNum = arrOfNum[i];
                    largestPos = i;
                }
            }

            for (int j = 0; j < arrOfNum.Length; j++)
            {
                if (arrOfNum[j] > SecondLargestNum)
                {
                    if (j != largestPos)
                    {
                        SecondLargestNum = arrOfNum[j];
                    }
                }
            }
            return SecondLargestNum;
        }
        public bool Search(int[] arrOfNum, int num)
        {
            bool isFound = false;


            for (int i = 0; i < arrOfNum.Length; i++)
            {
                if (arrOfNum[i] == num)
                {
                    isFound = true;
                }

            }

            return isFound;

        }
        public int OccurrencesCount(int[] arrOfNum, int num)
        {
            int Count = 0;

            for (int i = 0; i < arrOfNum.Length; i++)
            {
                if (arrOfNum[i] == num)
                {
                    Count++;
                }

            }

            // Console.Write("The number occurs {0} times", Count);

            return Count;
        }
        public int MaximumOccurrences(int[] arrOfNum)
        {
            int[] arrCount = new int[arrOfNum.Length];
            int LargestNum = 0;
            int position = 0;

            for (int j = 0; j < arrOfNum.Length; j++)
            {
                for (int i = 0; i < arrOfNum.Length; i++)
                {
                    if (arrOfNum[j] == arrOfNum[i])
                    {
                        arrCount[j]++;
                    }

                }

            }

            for (int i = 0; i < arrCount.Length; i++)
            {
                if (arrCount[i] > LargestNum)
                {
                    LargestNum = arrCount[i];
                    position = i;
                }
            }
            return arrOfNum[position];
        }
        public int SpaceCount(string sentence)
        {
            int numSpaces = 0;
            string character;


            for (int i = 0; i < sentence.Length; i++)
            {
                character = sentence.Substring(i, 1);

                if (character == " ")
                {
                    numSpaces++;
                }
            }


            return numSpaces;
        }
        public int WordCount(string sentence)
        {
            string character;
            int numWords = 1;


            for (int i = 0; i < sentence.Length; i++)
            {
                character = sentence.Substring(i, 1);

                if (character == " ")
                {
                    numWords++;
                }
            }


            return numWords;
        }
        public string ReplaceSpace(string sentence)
        {
            string character;
            
            for (int i = 0; i < sentence.Length; i++)
            {
                character = sentence.Substring(i, 1);

                if (character == " ")
                {
                    sentence = sentence.Replace(" ", "_");
                }
            }

            return sentence;
        }
        public int[] Sort(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {

                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }

                }
            }

            return array;

        }
        public int[] EvenNumbers(int[] arrayOfNum)
        {
            ArrayList evenNumberList = new ArrayList();

            for (int i = 0; i < arrayOfNum.Length - 1; i++)
            {
                if (arrayOfNum[i] % 2 == 0)
                {
                    // Console.WriteLine(arrayOfNum[i]);
                    evenNumberList.Add(arrayOfNum[i]);
                }
            }
            return evenNumberList.ToArray(typeof(int)) as int[];
        }
        public void Fibonacci(int a, int b, int counter, int number)
        {
            Console.Write("{0} ",a);

            if (counter < number)
            {
                Fibonacci(b, a + b, counter + 1, number);
            }
        }
        public string StringReverse(string Str)
        {
            int Length = Str.Length - 1;
            string reversedString = " ";

            while (Length >= 0)
            {
                reversedString = reversedString + Str[Length];
                Length--;
            }

            return reversedString;
        }
        public int StringToNumber(string numString)
        {
            int num = 0;

            Int32.TryParse(numString, out num);

            return num;
        }
        public int ConsecutiveDifference(int[] arrOfNum)
        {
            int difference = 0;
            int maxiDifference = 0;
            for (int i = 0; i < arrOfNum.Length-1; i++)
            {
                difference = arrOfNum[i + 1] - arrOfNum[i];

                if (difference > maxiDifference)
                {
                    maxiDifference = difference;
                }
            }

            return maxiDifference;
        }
        public int DigitsCount(int num)
        {
            return num.ToString().Length;
        }
        public int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }

            return sum;
        }
        public int SumOfOddDigits(int nNumber)
        {
            int[] arrOfNum = new int[nNumber];
            int sum = 0;


            for (int i = 0; i < arrOfNum.Length; i++)
            {
                arrOfNum[i] = i + 1;

                if (arrOfNum[i] % 2 != 0)
                {
                    sum = sum + arrOfNum[i];
                }
            }

            /*  for (int j = 0; j < arrOfNum.Length; j++)
              {

              }*/
            return sum;
        }
        public int DigitSwap(int num)
        {
            string numAsString = num.ToString();
            char temp;

            char[] digits = numAsString.ToCharArray();
            temp = digits[0];
            digits[0] = digits[digits.Length - 1];
            digits[digits.Length - 1] = temp;

            return (Int32.Parse(new string(digits)));

        }
        public bool VowelCheck(char alphabet)
        {
            switch (alphabet)
            {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }

        }
        public int IntegerReverse(int num)
        {
            string intAsString = num.ToString();
            int Length = intAsString.Length - 1;
            string reversedString = " ";

            while (Length >= 0)
            {
                reversedString = reversedString + intAsString[Length];
                Length--;

            }
            return Int32.Parse(reversedString);
        }
    }
}
