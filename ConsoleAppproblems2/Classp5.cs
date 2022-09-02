using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp5
    {
        static void Main5()
        {
            Console.WriteLine("Enter First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Since his/her age is "+a + " ,so they are eligible to cast a vote.");
            }
            else
            {
                Console.WriteLine("Since his / her age is "+a + ", so they are not eligible to cast a vote.");
            }
            Console.ReadKey();
        }
    }
}
