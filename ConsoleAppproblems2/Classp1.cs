using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp1
    {
        static void Main1()
        {
            Console.WriteLine("Enter First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(a + " and " + b + " are equal");
            }
            else
            {
                Console.WriteLine(a + " and " + b + " are not equal");
            }
            Console.ReadKey();
        }
    }
}
