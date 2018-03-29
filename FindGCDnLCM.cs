using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //gcd = 最大公因數
        //lcm = 最小公倍數
        static void Main(string[] args)
        {
            string end = "";

            do
            {
                Console.WriteLine("please input first number");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("please input second number");
                int n2 = int.Parse(Console.ReadLine());

                Swap(ref n1, ref n2);//調換大、小

                int gcd = Get_GCD(n1, n2);//find gcd

                int lcm = Get_LCM(gcd, n1, n2);//find lcm

                Console.WriteLine($"gcd:{gcd}");
                Console.WriteLine($"lcm:{lcm}");

                Console.WriteLine("Do you want to continue? Yes = 1, No = any key");
                end = Console.ReadLine();
            } while (end == "1");
        }

        private static int Get_GCD(int x, int y)
        {
            int remainder = 1;
            int ans = 0;
            while (remainder != 0)
            {
                ;
                remainder = x % y;
                Console.WriteLine($"num1:{x},num2:{y},remainder:{remainder}");

                x = y;
                if (remainder == 0)
                {
                    ans = y;
                }
                y = remainder;
            }
            return ans;
        }

        private static int Get_LCM(int gcd, int n1, int n2)
        {
            return (n1 / gcd) * (n2 / gcd) * gcd;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            if (a < b)
            {
                a = b;
                b = temp;
            }
        }
    }
}
