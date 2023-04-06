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
            int choice;
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

                    }
                    break;
            }
        }
    }
}
