using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15_Variance_in_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var myObj = new MyClass();
            //Console.WriteLine("Hello from Func: {0}", myAction(5, 5));
            Console.ReadLine();

        }


        public void Print() {
            Console.WriteLine("Hello from Action");
        }

    }

    class MyClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    
    }
}
