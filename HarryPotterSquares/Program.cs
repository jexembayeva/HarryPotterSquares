using System;

namespace HarryPotterSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *************************1***********************
            . # # # # # # # # # # # # # # # # # # # # # # # #
            . . # # # # # # # # # # # # # # # # # # # # # # #
            . . . # # # # # # # # # # # # # # # # # # # # # #
            . . . . # # # # # # # # # # # # # # # # # # # # #
            . . . . . # # # # # # # # # # # # # # # # # # # #
            . . . . . . # # # # # # # # # # # # # # # # # # #
            . . . . . . . # # # # # # # # # # # # # # # # # #
            . . . . . . . . # # # # # # # # # # # # # # # # #
            . . . . . . . . . # # # # # # # # # # # # # # # #
            . . . . . . . . . . # # # # # # # # # # # # # # #
            . . . . . . . . . . . # # # # # # # # # # # # # #
            . . . . . . . . . . . . # # # # # # # # # # # # #
            . . . . . . . . . . . . . # # # # # # # # # # # #
            . . . . . . . . . . . . . . # # # # # # # # # # #
            . . . . . . . . . . . . . . . # # # # # # # # # #
            . . . . . . . . . . . . . . . . # # # # # # # # #
            . . . . . . . . . . . . . . . . . # # # # # # # #
            . . . . . . . . . . . . . . . . . . # # # # # # #
            . . . . . . . . . . . . . . . . . . . # # # # # #
            . . . . . . . . . . . . . . . . . . . . # # # # #
            . . . . . . . . . . . . . . . . . . . . . # # # #
            . . . . . . . . . . . . . . . . . . . . . . # # #
            . . . . . . . . . . . . . . . . . . . . . . . # #
            . . . . . . . . . . . . . . . . . . . . . . . . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
             */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x < y
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************2***********************
            # . . . . . . . . . . . . . . . . . . . . . . . .
            . # . . . . . . . . . . . . . . . . . . . . . . .
            . . # . . . . . . . . . . . . . . . . . . . . . .
            . . . # . . . . . . . . . . . . . . . . . . . . .
            . . . . # . . . . . . . . . . . . . . . . . . . .
            . . . . . # . . . . . . . . . . . . . . . . . . .
            . . . . . . # . . . . . . . . . . . . . . . . . .
            . . . . . . . # . . . . . . . . . . . . . . . . .
            . . . . . . . . # . . . . . . . . . . . . . . . .
            . . . . . . . . . # . . . . . . . . . . . . . . .
            . . . . . . . . . . # . . . . . . . . . . . . . .
            . . . . . . . . . . . # . . . . . . . . . . . . .
            . . . . . . . . . . . . # . . . . . . . . . . . .
            . . . . . . . . . . . . . # . . . . . . . . . . .
            . . . . . . . . . . . . . . # . . . . . . . . . .
            . . . . . . . . . . . . . . . # . . . . . . . . .
            . . . . . . . . . . . . . . . . # . . . . . . . .
            . . . . . . . . . . . . . . . . . # . . . . . . .
            . . . . . . . . . . . . . . . . . . # . . . . . .
            . . . . . . . . . . . . . . . . . . . # . . . . .
            . . . . . . . . . . . . . . . . . . . . # . . . .
            . . . . . . . . . . . . . . . . . . . . . # . . .
            . . . . . . . . . . . . . . . . . . . . . . # . .
            . . . . . . . . . . . . . . . . . . . . . . . # .
            . . . . . . . . . . . . . . . . . . . . . . . . #
             */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x == y
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************3***********************
            . . . . . . . . . . . . . . . . . . . . . . . . #
            . . . . . . . . . . . . . . . . . . . . . . . # .
            . . . . . . . . . . . . . . . . . . . . . . # . .
            . . . . . . . . . . . . . . . . . . . . . # . . .
            . . . . . . . . . . . . . . . . . . . . # . . . .
            . . . . . . . . . . . . . . . . . . . # . . . . .
            . . . . . . . . . . . . . . . . . . # . . . . . .
            . . . . . . . . . . . . . . . . . # . . . . . . .
            . . . . . . . . . . . . . . . . # . . . . . . . .
            . . . . . . . . . . . . . . . # . . . . . . . . .
            . . . . . . . . . . . . . . # . . . . . . . . . .
            . . . . . . . . . . . . . # . . . . . . . . . . .
            . . . . . . . . . . . . # . . . . . . . . . . . .
            . . . . . . . . . . . # . . . . . . . . . . . . .
            . . . . . . . . . . # . . . . . . . . . . . . . .
            . . . . . . . . . # . . . . . . . . . . . . . . .
            . . . . . . . . # . . . . . . . . . . . . . . . .
            . . . . . . . # . . . . . . . . . . . . . . . . .
            . . . . . . # . . . . . . . . . . . . . . . . . .
            . . . . . # . . . . . . . . . . . . . . . . . . .
            . . . . # . . . . . . . . . . . . . . . . . . . .
            . . . # . . . . . . . . . . . . . . . . . . . . .
            . . # . . . . . . . . . . . . . . . . . . . . . .
            . # . . . . . . . . . . . . . . . . . . . . . . .
            # . . . . . . . . . . . . . . . . . . . . . . . .
             */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x + y == 24
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************4***********************
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # # # # # # # # # # # # # # # # # # # # # # # # .
            # # # # # # # # # # # # # # # # # # # # # # # . .
            # # # # # # # # # # # # # # # # # # # # # # . . .
            # # # # # # # # # # # # # # # # # # # # # . . . .
            # # # # # # # # # # # # # # # # # # # # . . . . .
            # # # # # # # # # # # # # # # # # # # . . . . . .
            # # # # # # # # # # # # # # # # # # . . . . . . .
            # # # # # # # # # # # # # # # # # . . . . . . . .
            # # # # # # # # # # # # # # # # . . . . . . . . .
            # # # # # # # # # # # # # # # . . . . . . . . . .
            # # # # # # # # # # # # # # . . . . . . . . . . .
            # # # # # # # # # # # # # . . . . . . . . . . . .
            # # # # # # # # # # # # . . . . . . . . . . . . .
            # # # # # # # # # # # . . . . . . . . . . . . . .
            # # # # # # # # # # . . . . . . . . . . . . . . .
            # # # # # # # # # . . . . . . . . . . . . . . . .
            # # # # # # # # . . . . . . . . . . . . . . . . .
            # # # # # # # . . . . . . . . . . . . . . . . . .
            # # # # # # . . . . . . . . . . . . . . . . . . .
             */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x + y < 30
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************5***********************
            # # . . . . . . . . . . . . . . . . . . . . . . .
            . . # # . . . . . . . . . . . . . . . . . . . . .
            . . . . # # . . . . . . . . . . . . . . . . . . .
            . . . . . . # # . . . . . . . . . . . . . . . . .
            . . . . . . . . # # . . . . . . . . . . . . . . .
            . . . . . . . . . . # # . . . . . . . . . . . . .
            . . . . . . . . . . . . # # . . . . . . . . . . .
            . . . . . . . . . . . . . . # # . . . . . . . . .
            . . . . . . . . . . . . . . . . # # . . . . . . .
            . . . . . . . . . . . . . . . . . . # # . . . . .
            . . . . . . . . . . . . . . . . . . . . # # . . .
            . . . . . . . . . . . . . . . . . . . . . . # # .
            . . . . . . . . . . . . . . . . . . . . . . . . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        Math.Floor((double)(y / 2)) == x
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************20***********************
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . # . # . # . # . # . # . # . # . # . # . # . # .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        (x + y) % 2 == 0
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            ************************21***********************
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # . # . # . # . # . # . # . # . # . # . # . # . #
            # . . # . . # . . # . . # . . # . . # . . # . . #
            # . . . # . . . # . . . # . . . # . . . # . . . #
            # . . . . # . . . . # . . . . # . . . . # . . . .
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . . # . . . . . . # . . . . . . # . . .
            # . . . . . . . # . . . . . . . # . . . . . . . #
            # . . . . . . . . # . . . . . . . . # . . . . . .
            # . . . . . . . . . # . . . . . . . . . # . . . .
            # . . . . . . . . . . # . . . . . . . . . . # . .
            # . . . . . . . . . . . # . . . . . . . . . . . #
            # . . . . . . . . . . . . # . . . . . . . . . . .
            # . . . . . . . . . . . . . # . . . . . . . . . .
            # . . . . . . . . . . . . . . # . . . . . . . . .
            # . . . . . . . . . . . . . . . # . . . . . . . .
            # . . . . . . . . . . . . . . . . # . . . . . . .
            # . . . . . . . . . . . . . . . . . # . . . . . .
            # . . . . . . . . . . . . . . . . . . # . . . . .
            # . . . . . . . . . . . . . . . . . . . # . . . .
            # . . . . . . . . . . . . . . . . . . . . # . . .
            # . . . . . . . . . . . . . . . . . . . . . # . .
            # . . . . . . . . . . . . . . . . . . . . . . # .
            # . . . . . . . . . . . . . . . . . . . . . . . #
            # . . . . . . . . . . . . . . . . . . . . . . . .
             */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        y % (x + 1) == 0
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************22***********************
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            . . # . . # . . # . . # . . # . . # . . # . . # .
            . # . . # . . # . . # . . # . . # . . # . . # . .
            # . . # . . # . . # . . # . . # . . # . . # . . #
            */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        (x + y) % 3 == 0
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************23***********************
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            . . . . . . . . . . . . . . . . . . . . . . . . .
            . . . . . . . . . . . . . . . . . . . . . . . . .
            # . # . # . # . # . # . # . # . # . # . # . # . #
            */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x % 3 + y % 2 == 0
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************24***********************
            # . . . . . . . . . . . . . . . . . . . . . . . #
            . # . . . . . . . . . . . . . . . . . . . . . # .
            . . # . . . . . . . . . . . . . . . . . . . # . .
            . . . # . . . . . . . . . . . . . . . . . # . . .
            . . . . # . . . . . . . . . . . . . . . # . . . .
            . . . . . # . . . . . . . . . . . . . # . . . . .
            . . . . . . # . . . . . . . . . . . # . . . . . .
            . . . . . . . # . . . . . . . . . # . . . . . . .
            . . . . . . . . # . . . . . . . # . . . . . . . .
            . . . . . . . . . # . . . . . # . . . . . . . . .
            . . . . . . . . . . # . . . # . . . . . . . . . .
            . . . . . . . . . . . # . # . . . . . . . . . . .
            . . . . . . . . . . . . # . . . . . . . . . . . .
            . . . . . . . . . . . # . # . . . . . . . . . . .
            . . . . . . . . . . # . . . # . . . . . . . . . .
            . . . . . . . . . # . . . . . # . . . . . . . . .
            . . . . . . . . # . . . . . . . # . . . . . . . .
            . . . . . . . # . . . . . . . . . # . . . . . . .
            . . . . . . # . . . . . . . . . . . # . . . . . .
            . . . . . # . . . . . . . . . . . . . # . . . . .
            . . . . # . . . . . . . . . . . . . . . # . . . .
            . . . # . . . . . . . . . . . . . . . . . # . . .
            . . # . . . . . . . . . . . . . . . . . . . # . .
            . # . . . . . . . . . . . . . . . . . . . . . # .
            # . . . . . . . . . . . . . . . . . . . . . . . #
            */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x == y || x == 24 - y
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

            /*
            *************************25***********************
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # . . . . . # . . . . . # . . . . . # . . . . . #
            # # # # # # # # # # # # # # # # # # # # # # # # #
            */
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(
                        x % 6 == 0 || y % 6 == 0
                        ? "# " : ". ");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
