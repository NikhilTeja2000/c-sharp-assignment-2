using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp11
    {
        static void Main11()
        {
            Console.WriteLine("Enter the number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            for (int c = 1; c < a+1; c++)
            {
                Console.WriteLine("Number is : "+c+" and cube of the "+c+" is :"+(c*c*c));
            }
            Console.ReadKey();
        }
    }
}
