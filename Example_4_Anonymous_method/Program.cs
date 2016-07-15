using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_Anonymous_method
{
    class Program
    {
        delegate void Anonymous(int k);

        static void Main(string[] args)
        {
            Anonymous anonym = delegate(int j)
            {
                for (int i = 1; i < j; i++)
                {
                    Console.WriteLine("Hello from anonymous method");
                }
            };

            anonym(4);
        }
    }
}
