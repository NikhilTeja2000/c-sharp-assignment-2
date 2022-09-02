using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp17
    {
        static void Main17()
        {
            Console.Write("enter number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a < k; a++)
            {
                String p = a.ToString();
                

                Console.WriteLine(string.Concat(Enumerable.Repeat(p, a)));
            }
            Console.ReadKey();
        }
    }
}
