using System;
using System.Collections.Generic;
using System.Text;

namespace Example_7_GenericClass
{
    class Printer<T> where T : class
    {
        T _value;
        public Printer(T value)
        {
            this._value = value;
        }

        public void Print()
        {
            Console.WriteLine("Input value is: {0}", this._value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }
    }
}
