using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppproblems2
{
    public class Classp4
    {
        static void Main4()
        {
            Console.WriteLine("Enter Year: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a%4)== 0)
            {

                if ((a % 100) == 0)
                {
                    if ((a % 400) == 0)
                    {

                        Console.WriteLine(a + " is leap year");
                    }
                    else
                    {
                        Console.WriteLine(a + " is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine(a + " is a leap year");
                }
            }
            else
            {
                Console.WriteLine(a + " is not a leap year");
            }
            /*The years 1900, 2100, 2200, 2300, 2500, 2600, 2700, 2900 and 3000 are not leap years.leap years are:
             1904	1908	1912	1916	1920	1924	1928	1932	1936
1940	1944	1948	1952	1956	1960	1964	1968	1972	1976
1980	1984	1988	1992	1996	2000	2004	2008	2016	2020
2024	2028	...*/
            Console.ReadKey();
        }
    }
}
