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
            int choice = -1;
            int currentMenu = 0;
            int corner = 0;
            while (choice != 0)
            {
                Console.WriteLine("Welcome!");
                Console.ReadKey();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Print a rectangle");
                Console.WriteLine("2. Print a square triangle");
                Console.WriteLine("3. Print a square isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("------------------------------------");
                Console.Write("Input your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                currentMenu++;
                Console.WriteLine($"Current Menu is {currentMenu}");
                {
                    int i, j;
                    switch (choice)
                    {
                        case 1:
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
                        case 2:
                            for (i = 0; i < 5; i++)
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
                                corner = Int32.Parse(Console.ReadLine());
                                currentMenu++;
                                Console.WriteLine("------------------------------------");
                            }
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
