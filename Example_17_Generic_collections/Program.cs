using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_17_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = new List<double>();
            myList.Add(1.23);
            myList.Add(209.34);
            myList.Insert(1, 39.9);
            myList.Add(38.2);
            myList.Remove(1.23);
           // Console.WriteLine("IndexOf {0} = {1}", 209.34, myList.IndexOf(209.34));
           // Console.WriteLine("IndexOf {0} = {1}", 1.23, myList.IndexOf(1.23));
            for (int ij = 0; ij < myList.Count; ij++)
                Console.WriteLine(myList[ij]);
            Console.ReadLine();
        }
    }
}
