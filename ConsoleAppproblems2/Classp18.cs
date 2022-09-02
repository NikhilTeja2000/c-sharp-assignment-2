using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp18
    {
        static void Main18()
        {
            Console.Write("enter number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int d = 1;
            for (int a = 1; a < k; a++)

            {
                for (int b = 1; b < a + 1; b++)
                {
                    Console.Write(d+" ");
                    d = d + 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
