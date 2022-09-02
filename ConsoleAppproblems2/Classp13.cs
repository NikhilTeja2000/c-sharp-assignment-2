using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp13
    {
        static void Main13()
        {
            Console.WriteLine("Input the number (Table to be calculated) : ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int g = 1; g < a+1; g++)
            {
                for (int c = 1; c < 11; c++)
                {
                    if (c == 10)
                    {

                        Console.Write(g + "*" + c + "=" + (g * c));
                    }
                    else
                    {

                        Console.Write(g + "*" + c + "=" + (g * c) + ",    ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
