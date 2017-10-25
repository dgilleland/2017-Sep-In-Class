using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        #region Driver
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                DisplayMenu();
                userInput = Console.ReadLine().ToUpper();
                ProcessMenuChoice(userInput);

            } while (userInput != "X");
        }

        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A) Draw Box");
            Console.WriteLine("B) Draw Slash");
            Console.WriteLine("C) Draw Backslash");
            Console.WriteLine("D) Draw X");
            Console.WriteLine("E) Draw Z");
            Console.WriteLine("F) Draw Tic-Tac-Toe board");

            Console.WriteLine("X) eXit ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\tEnter a menu choice: ");
            Console.ResetColor();
        }

        private static void ProcessMenuChoice(string choice)
        {
            int size;
            switch(choice)
            {
                case "A":
                    size = GetSize();
                    DrawBox(size);
                    break;
                case "B":
                    size = GetSize();
                    DrawSlash(size);
                    break;
                case "C":
                    size = GetSize();
                    DrawBackslash(size);
                    break;
                case "D":
                    size = GetSize();
                    DrawX(size);
                    break;
                case "E":
                    size = GetSize();
                    DrawZ(size);
                    break;
                case "F":
                    DrawTicTacToe();
                    break;
                case "X":
                    Console.WriteLine("\n\nGoodbye!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tInvalid menu choice.");
                    Console.ResetColor();
                    break;
            }
        }
        #endregion

        #region Draw methods
        static int GetSize()
        {
            int size;
            Console.Write("\nWhat size do you want (4-10)? ");
            while (!int.TryParse(Console.ReadLine(), out size) || size < 4 || size > 10)
                Console.WriteLine("\tInvalid number. Try again: ");
            return size;
        }

        static void DrawBox(int size)
        {
            for(int row = 1; row <= size; row++)
            {
                for(int col = 1; col <= size; col++)
                {
                    if (row == 1 || row == size || col == 1 || col == size)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        static void DrawSlash(int size)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    if (row + col == size + 1)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        static void DrawBackslash(int size)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    if (row == col)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        static void DrawX(int size)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    if (row == col || row + col == size + 1)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private static void DrawZ(int size)
        {
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= size; col++)
                {
                    if (row == 1 || row == size || row + col == size + 1)
                        Console.Write("Z");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void DrawTicTacToe()
        {
            
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    if (row % 2 == 0 && col % 2 == 0)
                        Console.Write("+");
                    else if (row % 2 == 0)
                        Console.Write("-");
                    else if (col % 2 == 0)
                        Console.Write("|");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
