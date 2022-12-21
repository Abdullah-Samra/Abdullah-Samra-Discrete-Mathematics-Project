using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //عبدالله أحمد فتحي محمد محمد الحنفي سمره 

            bool flag = false;
            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe Prime number from {0} to {1} is:", n1, n2);
            Console.WriteLine("______________________________________\n");

            for (; n1 <= n2; n1++)
            {
                for (int i = n1 - 1; 1 < i; i--)
                {
                    if (n1 % i != 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (n1 == 2)
                {
                    flag = true;
                }
                if (flag == true)
                    Console.WriteLine("\n" + n1);
            }
            Console.ReadKey();

        }
    }
}
