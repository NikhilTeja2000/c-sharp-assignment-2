using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp6
    {
        static void Main6()
        {
            Console.WriteLine("Enter m: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("The value of n = "+ 1);
            }
            else if(a == 0)
            {

                Console.WriteLine("The value of n = " + 0);
            }
            else
            {
                Console.WriteLine("The value of n = " + -1);
            }
            Console.ReadKey();
        }
    }
}
