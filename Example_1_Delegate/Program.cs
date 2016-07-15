using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Delegate
{
    class Program
    {
        public delegate int UpOnHandler(int i);

        class UpOn
        {
            public int Increment(int i)
            {
                return ++i;
            }

            public int Decrement(int i)
            {
                return --i;
            }
        }

        static void Main(string[] args)
        {
            UpOn myUp = new UpOn();
            UpOnHandler myIncDelegate = new UpOnHandler(myUp.Increment);
            int incrResult = myIncDelegate.Invoke(2);
            Console.WriteLine("Increment result: {0}", incrResult);

            UpOnHandler myDecDelegate = myUp.Decrement;
            int decResult = myDecDelegate(2);
            Console.WriteLine("Decrement result: {0}", decResult);
            Console.ReadLine();
        }
    }
}
