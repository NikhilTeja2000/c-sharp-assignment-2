using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp8
    {
        static void Main8()
        {
            Console.WriteLine("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {

                if (a >c)
                {

                        Console.WriteLine(a + " is largest number");
                }

                else
                {
                    Console.WriteLine(c + " is largest number");

                }

            }
            else if(b>a)

            {
                if (b > c)
                {

                    Console.WriteLine(b + " is largest number");
                }

                else
                {
                    Console.WriteLine(c + " is largest number");

                }
            }
            Console.ReadKey();
        }

    }
}
