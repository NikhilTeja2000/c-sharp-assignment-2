using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp14
    {
        static void Main14()
        {
            Console.WriteLine("Input the number (Table to be calculated) : ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            List<int> oddnum = new List<int>();
            int m = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                if (i % 2 != 0)
                {
                    oddnum.Add(i);
                    m = m + i;
                }
                if (oddnum.Count == a)
                {
                    break;
                }
            }
            Console.Write("The odd numbers are : ");
            foreach (int j in oddnum)
            {
                if (oddnum[oddnum.Count-1] == j)
                {

                    Console.Write(j);
                }
                else
                {

                    Console.Write(j + ",");
                }

            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto 10 terms : " + m);
            Console.ReadKey();

        }
    }
}
