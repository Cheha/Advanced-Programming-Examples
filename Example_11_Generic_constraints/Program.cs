using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11_Generic_constraints
{
    public class CustomClass
    {
        public void Method<T>(T value)
            where T : struct
        {
            Console.WriteLine("Our structure: {0}", value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customClass = new CustomClass();
            customClass.Method<int>(55);
        }
    }
}
