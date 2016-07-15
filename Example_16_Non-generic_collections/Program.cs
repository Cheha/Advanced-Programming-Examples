using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16_Non_generic_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList 
            ArrayList arrayList = new ArrayList();
            arrayList.Add("First item");
            arrayList.Add(5);
            arrayList.Add('c');

            foreach (var item in arrayList) {
                Console.WriteLine("Element of arrayList: {0}", item);
            }

            //HashTable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(0, "Zero item");
            hashtable[1] = "First item";
            hashtable["2"] = "Second item";
            hashtable[Guid.NewGuid()] = "Third item";

            ICollection keys = hashtable.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, hashtable[key]);
            }

            //SortedList
            SortedList sl = new SortedList();

            sl.Add("007", "Ritesh Saikia");
            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("006", "M. Amlan");
            sl.Add("005", "M. Arif");
            

            ICollection slValues = sl.Values;
            foreach (var s in slValues) {
                Console.WriteLine("SortedList value: {0}", s);
            }
             //Queue is FIFO: First in First out
            Queue que = new Queue();
            que.Enqueue("Student_1");
            que.Enqueue(5);
            que.Enqueue("Student_2");
            que.Enqueue("Student_3");
            
            Console.WriteLine(que.Dequeue().ToString());
            Console.WriteLine(que.Dequeue().ToString()); 

            // Stack is FILO: First in Last out
            Stack StackPop = new Stack();
            StackPop.Push("Student_1");
            StackPop.Push("Student_2");
            StackPop.Push("Student_3");
            Console.WriteLine(StackPop.Pop().ToString());
            Console.WriteLine(StackPop.Pop().ToString());

            Console.ReadLine();
        }
    }
}
