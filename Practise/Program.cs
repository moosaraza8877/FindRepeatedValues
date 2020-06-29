using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b, s, p, r;
            s = 0;
            p = 1;
            Console.Write("Enter the Binary Number, 0's and 1's: ");
            n = Convert.ToInt32(Console.ReadLine());
            b = n;
            while (n > 0)
            {
                r = n % 10;
                n = n / 10;
                s = s + r * p;
                p = p * 2;
            }
            Console.WriteLine("The Binary Number is: {0}", b);
            Console.WriteLine("It's Decimal Equivalent Number is: {0}", s);
            Console.WriteLine("  ********** THE END **********  ");
        }
    }
}
