using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp16
    {
        static void Main16()
        {
            Console.Write("enter number: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a < k; a++)

            {
                for (int b = 1; b < a+1; b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
