using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp7
    {
       static void Main7()
        {
            Console.WriteLine("Enter height: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <150)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else if (a >150 && a<170)
            {

                Console.WriteLine("The person is Normal Height");
            }
            else
            {
                Console.WriteLine("The person is Height");
            }
            Console.ReadKey();
        }
    }
}
