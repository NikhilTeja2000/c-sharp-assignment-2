using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp2
    {
        static void Main2()
        {

            Console.WriteLine("Enter First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a%2)==0)
            {
                Console.WriteLine(a + " is even number");
            }
            else
            {
                Console.WriteLine(a + " is odd number");
            }
            Console.ReadKey();
        }
    }
}
