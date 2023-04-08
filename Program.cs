using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentMenu = 0;
            int i, j;
            int retry = 0;
            string input = "Input";
            string corner = "Corner";
            while (input != "0")
            {
                if (retry >= 3)
                {
                    Console.WriteLine("No more retries");
                    break;
                    return;
                }
                else if (currentMenu == 0 && retry < 3)
                {
                    Console.WriteLine("Welcome!");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Menu");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1. Print a rectangle");
                    Console.WriteLine("2. Print a square triangle");
                    Console.WriteLine("3. Print a isosceles triangle");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("------------------------------------");
                    Console.Write("Input your choice: ");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Print a rectangle");
                            for (i = 0; i < 5; i++)
                            {
                                for (j = 0; j < 10 - i; j++)
                                {
                                    if (i == 0 || i == 2)
                                    {
                                        if (j % 2 == 0)
                                        {
                                            Console.Write("*");
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    else
                                    {
                                        if (j == 0 || j == 8)
                                        {
                                            Console.Write("*");
                                        }
                                        else
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "2":
                            currentMenu++;
                            break;
                        case "3":
                            Console.WriteLine("Print a isosceles triangle");
                            for (i = 1; i <= 5; i++)
                            {
                                for (j = 2; j <= 6 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            retry++;
                            break;
                    }
                }
                else if (currentMenu == 1)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Select your square triangle");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1. Top-Left");
                    Console.WriteLine("2. Top-Right");
                    Console.WriteLine("3. Bottom-Left");
                    Console.WriteLine("4. Bottom-Right");
                    Console.WriteLine("5. Back");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("------------------------------------");
                    Console.Write("Input your choice: ");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Print a Top-Left Square Triangle");
                            for (i = 1; i <= 5; i++)
                            {
                                for (j = 1; j <= 6 - i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "2":
                            Console.WriteLine("Print a Top-Right Square Triangle");
                            for (i = 1; i <= 5; i++)
                            {
                                for (j = 2; j <= i; j++)
                                {
                                    Console.Write("  ");
                                }
                                for (j = 1; j <= 6 - i; j++)
                                {
                                    Console.Write(" *");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "3":
                            Console.WriteLine("Print a Bottom-Left Square Triangle");
                            for (i = 1; i <= 5; i++)
                            {
                                for (j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "4":
                            for (i = 1; i <= 5; i++)
                            {
                                for (j = 2; j <= 6 - i; j++)
                                {
                                    Console.Write("  ");
                                }
                                for (j = 1; j <= i; j++)
                                {
                                    Console.Write(" *");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "5":
                            currentMenu = 0;
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            retry++;
                            break;
                    }
                }
                //Console.WriteLine($"Your retries: {retry}");
                //Console.WriteLine($"Current Menu is {currentMenu}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
