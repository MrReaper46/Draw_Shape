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
            while (input != "0")
            {
                if (retry >= 3)
                {
                    Console.WriteLine("No more retries");
                    return;
                }
                else if (currentMenu == 0 && retry < 3)
                {
                    Console.WriteLine("Welcome!");
                    Console.ReadKey();
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
                    Console.WriteLine("------------------------------------");
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Print a rectangle");
                            for (i = 0; i < 3; i++)
                            {
                                for (j = 0; j < 10; j++)
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
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        case null:
                            Console.WriteLine("No input... Try again");
                            retry++;
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            retry++;
                            break;
                    }
                }
                else if (currentMenu == 1)
                {
                    int corner = 0;
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
                    corner = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("------------------------------------");
                    for (i = 0; i < 5; i++)
                    {
                        switch (corner)
                        {
                            case 5:
                                currentMenu = 0;
                                break;
                        }
                    }
                }
                Console.WriteLine($"Current Menu is {currentMenu}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
