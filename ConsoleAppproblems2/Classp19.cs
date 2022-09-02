using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp19
    {
        static void Main19()
        {
            Console.Write("enter number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int d = 1;
            for (int a = 1; a < k; a++)


            {

                string s = new string(' ', 5 - a);
                Console.Write(s);
                for (int b = 1; b < a + 1; b++)
                {
                    Console.Write(d+" ");
                    d = d + 1;
                }
                Console.Write(s);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
