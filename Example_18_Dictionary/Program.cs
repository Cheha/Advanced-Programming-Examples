using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_18_Dictionary
{
    public class DictRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DictRecord objectRecord = new DictRecord()
            {
                Id = 34,
                FirstName = "Ivanko",
                LastName = "Ssdadsdsad"
            };

            Dictionary<int, DictRecord> Person_dictionary = new Dictionary<int, DictRecord>();
            Person_dictionary.Add(1, new DictRecord()
            {
                Id = 34,
                FirstName = "Rebecca",
                LastName = "Tetchar"
            });
            Person_dictionary.Add(3, new DictRecord()
            {
                Id = 3,
                FirstName = "Mary",
                LastName = "First"
            });
            Person_dictionary.Add(5, new DictRecord()
            {
                Id = 1,
                FirstName = "Robert",
                LastName = "Stown"
            });
            Person_dictionary.Add(34, objectRecord);
            //Person_dictionary.Remove(3);
            foreach (KeyValuePair<int, DictRecord> dictObj in Person_dictionary)
            {
                Console.WriteLine("Key:{0}, Value:{1}", dictObj.Key, dictObj.Value.FirstName);
            }

            foreach (var dictObj in Person_dictionary)
            {
                Console.WriteLine("Key:{0}, Value:{1}", dictObj.Key, dictObj.Value.FirstName);
            }

            //Console.WriteLine(Person_dictionary[3].FirstName);
            //Console.WriteLine(Person_dictionary[1].FirstName);
            //Console.WriteLine(Person_dictionary[34].FirstName);

            Console.ReadLine();


        }
    }
}
