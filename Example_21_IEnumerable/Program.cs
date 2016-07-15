using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_21_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");

            //create IEnumerable of string  
            IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;
            ////If we want to retrieve all the items from this IEnumerable object, we can use a foreach loop. 
            //Console.WriteLine("Retrieve items using IEnumerable");
            //foreach (string AllMonths in iEnumerableOfString)
            //{
            //    Console.WriteLine(AllMonths);
            //}

            //Create IEnumerator of string.
            //IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();//to convert list into IEnumerator we can invoke the GetEnumerator method  
            //To retrieve all the items from the above IEnumerator object, we cannot use foreach loop instead of that we need to invoke MoveNext() Boolean method.  
            Console.WriteLine("Retrieve items using IEnumerator");
            ToSummer(iEnumerableOfString);
            Console.ReadLine();

        }

        public static void ToSummer(IEnumerable<string> inumOfStr)
        {
            foreach (string month in inumOfStr)
            {
                if (month == "June")
                {
                    FromSummer(inumOfStr);
                }
                else {
                    Console.WriteLine(month);
                }
            }
            
        }

        public static void FromSummer(IEnumerable<string> inumOfStr)
        {
            foreach (string month in inumOfStr)
            {
                Console.WriteLine(month);
            }
        }
    }
}
