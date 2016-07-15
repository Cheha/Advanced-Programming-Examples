using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_Lambda_expressions
{
    class Program
    {
        delegate int Sqr(int x);
        delegate double Pow(int x, int i);

        static void Main(string[] args)
        {
            Sqr expression = x => x*x;
            Console.WriteLine("Squares:");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(expression(i));
            }

            Pow powExp = (x, i) => Math.Pow((double)x, (double)i);
            Console.WriteLine("Power {0} by {1} equals {2}", 3, 4, powExp(3,4));

        }
    }
}
