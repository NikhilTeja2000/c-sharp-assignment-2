using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp3
    {
        static void Main3()
        {
            Console.WriteLine("Enter First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine(a + " is positive number");
            }
            else
            {
                Console.WriteLine(a + " is negative number");
            }
            Console.ReadKey();
        }
    }
}
