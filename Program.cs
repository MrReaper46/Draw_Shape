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
            for (int i=0; i < 5; i++)
            {
                for(int j=0; j < 10; j++)
                {
                    if (i == 0)
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
                    if (i == 4)
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
                    if (i > 0 && i < 4)
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
        }
    }
}
