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
            int menu = 1;
            string str1, str2;
            Console.WriteLine("***** PALINDROME DETECTOR *****");
            while (menu == 1)
            {
                Console.WriteLine();
                Console.Write("Enter any word: ");
                str1 = Console.ReadLine();
                if (str1 == "/END")
                    break;
                str2 = null;
                for (int i = str1.Length - 1; i >= 0; i--)
                {
                    str2 = str2 + str1.Substring(i, 1);
                }
                if (str1 == str2)
                {
                    Console.WriteLine("It's a Palindrome!");
                }
                else
                    Console.WriteLine("It is not a Palindrome!");
                Console.WriteLine();
                Console.WriteLine("X----------X----------X");
                Console.WriteLine();
                Console.WriteLine("Are you want to check it again?");
                Console.Write("Press 1 for start again & 0 for exit: ");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                    continue;
                else
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using our detector!");
        }
    }
}