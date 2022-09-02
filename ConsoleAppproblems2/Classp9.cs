using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp9
    {
        static void Main9()
        {
            Console.WriteLine("Enter X: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a>0 && b>0)
            {
                Console.WriteLine("The coordinate point("+a+","+b+") lies in the First quadrant.");
            }
            else if (a >0 && b <0)
            {

                Console.WriteLine("The coordinate point(" + a + "," + b + ") lies in the Second quadrant.");
            }
            else if (a <0 && b >0)
            {

                Console.WriteLine("The coordinate point(" + a + "," + b + ") lies in the Third quadrant.");
            }
            else
            {
                Console.WriteLine("The coordinate point(" + a + "," + b + ") lies in the Fourth quadrant.");
            }
            Console.ReadKey();
        }
    }
}
