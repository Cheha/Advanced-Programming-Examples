using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10_Generic_Methods
{
    public class Printer
    {
        public void Print<T>(T value)
        {
            Console.WriteLine("Value: {0}", value);
        }

        public void Print<T, U>(T tvalue, U uvalue)
        {
            Console.WriteLine("{0} value: {1}", typeof(T), tvalue);
            Console.WriteLine("{0} value: {1}", typeof(U), uvalue);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Print<int>(5);
            printer.Print<string>("Input value");

            printer.Print<float, char>(0.8f, '6');
        }
    }
}
