using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp20
    {
        static void Main()
        {
            Console.Write("enter number: ");
            int k = Convert.ToInt32(Console.ReadLine());
          
                for (int a = 1; a < k; a++)


            {

                string s = new string(' ', 5 - a);
                Console.Write(s);
                Console.WriteLine(string.Concat(Enumerable.Repeat("* ", a)));


                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
