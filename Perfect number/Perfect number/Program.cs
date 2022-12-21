using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //عبدالله أحمد فتحي محمد محمد الحنفي سمره 

            Console.Write("Enter first number: ");
            long n1 = long.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            long n2 = long.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Perfect number from {0} to {1} is:", n1, n2);
            Console.WriteLine("______________________________________\n");
            for (; n1 <= n2; n1++)
            {
                long sum = 0;
                for (long i = n1 - 1; i >= 1; i--)
                {
                    if (n1 % i == 0)
                        sum = sum + i;
                }

                if (sum == n1)
                    Console.WriteLine("\n" + n1);
            }
            Console.ReadKey();
        }
    }
}
