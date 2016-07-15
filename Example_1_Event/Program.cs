using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Event
{
    class BirdEventArgs
    { 
    }

    class BirdEventHandler
    {
    }

    class Bird
    {
        private bool isFlyAway;
        public int crit_diff;
        
        public int FlySpeed { get; set; }
        public int NormalSpeed { get; set; }
        public string Nick { get; set; }

        public event BirdEventHandler Startle;

        public delegate void BirdEventHandler(object sender, BirdEventArgs e);
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
