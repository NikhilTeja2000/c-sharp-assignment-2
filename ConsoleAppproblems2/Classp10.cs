using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp10
    {
        static void Main10()
        {
            Console.WriteLine("the marks obtained in Physics : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the marks obtained in Chemistry : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the marks obtained in Maths : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>=65 && b>=55 && c>=50)
            {
                if (a + b + c >= 180)
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else if (c + a >= 140)
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else
                {

                    Console.WriteLine("The candidate is not eligible for admission.");
                }
            }
            else
            {

                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadKey();
        }
    }
}
