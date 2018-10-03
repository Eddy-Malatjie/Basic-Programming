using System;

namespace Star_Pattern_Exercise
{
    class Pattern
    {
        public void SquareStar(int nNumber)
        {
            for (int j = 0; j < nNumber; j++)
            {
                for (int i = 0; i < nNumber; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void HollowSquareStar(int nNumber)
        {
            for (int i = 1; i <= nNumber; i++)
            {
                for (int j = 1; j <= nNumber; j++)
                {
                    if (i == 1 || i == nNumber || j == 1 || j == nNumber)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
        public void DiagonalHollowSquareStar(int nNumber)
        {
            for (int i = 1; i <= nNumber; i++)
            {
                for (int j = 1; j <= nNumber; j++)
                {
                    if (i == 1 || i == nNumber || j == i || ((i + j) == nNumber) || j == 1 || j == nNumber)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

        }
        public void RhombusStar(int nNumber)
        {
            for (int i = nNumber; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void HollowRhombusStar(int nNumber)
        {
            for (int i = 1; i <= nNumber; i++)
            {
                for (int j = i; j < nNumber; j++)
                {

                    Console.Write(' ');
                }

                for (int j = 1; j <= nNumber; j++)
                {
                    if (i == 1 || i == nNumber || j == 1 || j == nNumber)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        public void MirroredRhombusStar(int nNumber)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void HollowMirroredRhombusStar(int nNumber)
        {

            for (int i = 1; i <= nNumber; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= nNumber; k++)
                {
                    if (i == 1 || i == nNumber || k == 1 || k == nNumber)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

        }
        public void RightTriangleStar(int nNumber)
        {

            for (int i = 1; i <= nNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void HollowRightTriangleStar(int nNumber)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
        public void MirroredRightTriangleStar(int nNumber)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void HollowMirroredRightTriangleStar(int nNumber)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i == 5 || j == 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
        public void InvertedRightTriangleStar(int nNumber)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void HollowInvertedRightTriangleStar(int nNumber)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 5 || j == 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
        public void InvertedMirroredRightTriangleStar(int nNumber)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void HollowInvertedMirroredRightTriangleStar(int nNumber)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    if (i == 5 || k == 1 || k == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
        public void PyramidStar(int nNumber)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void HollowPyramidstar(int nNumber)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == 5 || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void InvertedPyramidStar(int nNumber)
        {

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void HollowInvertedPyramidStar(int nNumber)
        {
            for (int i = nNumber; i >= 1; i--)
            {
                for (int j = i; j < nNumber; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == nNumber || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void HalfDiamondStar(int nNumber)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int l = 5; l >= 1; l--)
            {
                for (int m = 1; m < l; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void MirroredHalfDiamondStar(int nNumber)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int l = 5; l >= 1; l--)
            {
                for (int m = l; m <= 5; m++)
                {
                    Console.Write(" ");
                }
                for (int n = 1; n < l; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }
}
