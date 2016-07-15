using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Multicasting
{
    class Program
    {
        public delegate int UpOnHandler(int i);

        class UpOn
        {
            public int Increment(int i)
            {
                var result = ++i;
                Console.WriteLine(result);
                return result;
            }

            public int Decrement(int i)
            {
                var result = --i;
                Console.WriteLine(result);
                return result;
            }
        }

        static void Main(string[] args)
        {
            UpOn myUp = new UpOn();
            UpOnHandler myIncDelegate = new UpOnHandler(myUp.Increment);


            UpOnHandler myDecDelegate = myUp.Decrement;
       

            Console.WriteLine("Multicasting...");
            var myDelegate = myIncDelegate;
            int m = myIncDelegate(1);

            myDelegate += myDecDelegate;
            m = myDelegate(5);

            myDelegate -= myDecDelegate;
            m = myDelegate(1);

            Console.ReadLine();
        }
    }
}
