using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9_Generic_Interface
{
    public interface IPrinter<T>
    {
        void Print(T value);
    }

    public class IntPrinter : IPrinter<int>
    {

        public void Print(int value)
        {
            Console.WriteLine("Value: {0}", value);
        }
    }

    public class StringPrinter : IPrinter<string>
    {

        public void Print(string value)
        {
            Console.WriteLine("Value: {0}", value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
