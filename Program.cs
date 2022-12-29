using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start number: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("End numder: ");
            int e = int.Parse(Console.ReadLine());

            bool prime = true;

            for (int x = s; x <= e; x++)
            {
                for (int y = 2; y <= x; y++)
                {
                    if (x % y == 0 && x != y)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime && x > 1)
                {
                    Console.WriteLine(x);
                }
                prime = true;
            }
            Console.WriteLine("_______________");

        }
    }
}
