using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8_Generic_delegate
{
    class Program
    {
        // classic delegate example
        //public delegate int DelegateInt(int a, int b);
        

        public delegate T GenericDelegate<T>(T a, T b);

        public static int addInt(int a, int b)
        {
            return a + b;
        }

        public static double addDouble(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //var delegateInt = new DelegateInt(addInt);
            //var delegateResult = delegateInt(5,6);

            var doubleDelegate = new GenericDelegate<double>(addDouble);
            var intDelegate = new GenericDelegate<int>(addInt);
        }
    }
}
