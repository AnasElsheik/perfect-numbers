using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 == 0)
                n1++;
            int n, i, sum;
            for(n =n1; n <= n2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.ReadLine();
        }
    }
}
