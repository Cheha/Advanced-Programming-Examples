using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_19_IComparable
{
    public class PilotComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Airplane plane1 = x as Airplane;
            Airplane plane2 = y as Airplane;
            if (plane1 != null && plane2 != null)
            {
                return string.Compare(plane1.Pilot, plane2.Pilot);
            }
            else
            { 
                throw new ArgumentException("Parameter is not a Airplane!");
            }
        }

        
    }

    public class Airplane : IComparable
    {
        public string Pilot { get; set; }
        public string AirplaneId { get; set; }


        public static IComparer SortByPilot
        { 
            get 
            {
                return (IComparer)new PilotComparer();            
            }
        }



        public int CompareTo(object obj)
        {
            Airplane plane = obj as Airplane;
            if (plane != null)
                return this.AirplaneId.CompareTo(plane.AirplaneId);
            else
                throw new ArgumentException("Parameter is not a Airplane!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var planes = new Airplane[] {
                new Airplane { AirplaneId = "1", Pilot = "Pilot 1"},
                new Airplane { AirplaneId = "4", Pilot = "Pilot 4"},
                new Airplane { AirplaneId = "2", Pilot = "Pilot 2"},
                new Airplane { AirplaneId = "7", Pilot = "Pilot 7"}
            };

            Console.WriteLine("The unordered set of airplanes");
            foreach (Airplane plane in planes) {
                Console.WriteLine("{0} {1}", plane.AirplaneId, plane.Pilot);
            }
            Array.Sort(planes);
            Console.WriteLine();
            Console.WriteLine("The ordered set of airplanes");
            foreach (Airplane plane in planes) {
                Console.WriteLine("{0} {1}", plane.AirplaneId, plane.Pilot);
            }
            Console.WriteLine();
            Array.Sort(planes, Airplane.SortByPilot);
            Console.WriteLine("Ordering by pilot");
            foreach (Airplane plane in planes)
            {
                Console.WriteLine("{0} {1}", plane.AirplaneId, plane.Pilot);
            }
        }
    }
}
