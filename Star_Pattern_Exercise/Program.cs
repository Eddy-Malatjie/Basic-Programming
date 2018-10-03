using System;

namespace Star_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern Patt = new Pattern();

            
            Console.WriteLine("//Square Star Pattern");
            Patt.SquareStar(10);

            Console.WriteLine("//Hollow Square Star Pattern");
            Patt.HollowSquareStar(10);

            Console.WriteLine("//Hollow Square Star Pattern with Diagonal"); 
            Patt.DiagonalHollowSquareStar(10);

            Console.WriteLine("//Rhombus Star Pattern"); 
            Patt.RhombusStar(10);

            Console.WriteLine("//Hollow Rhombus Star Pattern");
            Patt.HollowRhombusStar(10);

            Console.WriteLine("//Mirrored Rhombus Star Pattern");
            Patt.MirroredRhombusStar(10);

            Console.WriteLine("//Hollow Mirrored Rhombus Star Pattern");
            Patt.HollowMirroredRhombusStar(10);

            Console.WriteLine("//Right Triangle Star Pattern");
            Patt.RightTriangleStar(10);

            Console.WriteLine("//Hollow Right Triangle Star Pattern");
            Patt.HollowRightTriangleStar(10);

            Console.WriteLine("//Mirrored Right Triangle Star Pattern");
            Patt.MirroredRightTriangleStar(10);

            Console.WriteLine("//Hollow Mirrored Right Triangle Star Pattern");
            Patt.HollowMirroredRightTriangleStar(10);

            Console.WriteLine("//Inverted Right Triangle Star Pattern");
            Patt.InvertedRightTriangleStar(10);

            Console.WriteLine("//Hollow Inverted Right Triangle Star Pattern ");          
            Patt.HollowInvertedRightTriangleStar(10);

            Console.WriteLine("//Inverted Mirrored Right Triangle Star Pattern");
            Patt.InvertedMirroredRightTriangleStar(10);

            Console.WriteLine("//Hollow Inverted Mirrored Right Triangle Star Pattern");
            Patt.HollowInvertedMirroredRightTriangleStar(10);

            Console.WriteLine("//Pyramid Star Pattern");
            Patt.PyramidStar(10);

            Console.WriteLine("//Hollow Pyramid Star Pattern");
            Patt.HollowPyramidstar(10);

            Console.WriteLine("//Inverted Pyramid Star Pattern");
            Patt.InvertedPyramidStar(10);

            Console.WriteLine("//Hollow Inverted Pyramid Star Pattern");
            Patt.HollowInvertedPyramidStar(10);

            Console.WriteLine("//Half Diamond Star Pattern");
            Patt.HalfDiamondStar(10);

            Console.WriteLine("//Mirrored Half Diamond Star Pattern");
            Patt.MirroredHalfDiamondStar(10);

            Console.ReadKey();




































        }
    }
}
