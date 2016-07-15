using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Event
{
    class Bird
    {
        // Birs publisher
        public int FlySpeed { get; set; }
        public int NormalSpeed { get; set; }
        public string Nick { get; set; }

        private bool BirdFlewAway;
        public int crit_diff;

        public event BirdEventHandler Startle;
        public delegate void BirdEventHandler(object sender, BirdEventsArgs e);

        public class BirdEventsArgs 
        {
            public readonly string mess;
            public BirdEventsArgs(string mess)
            {
                this.mess = mess;
            }
        }

        public Bird(int CritDiff, int FlySpeed)
        {
            this.crit_diff = CritDiff;
            this.FlySpeed = FlySpeed;
        }

        public void FlyAway(int increment)
        {
            if (BirdFlewAway)
            {
                Console.WriteLine("Bird flew away");
            }
            else {
                NormalSpeed += increment;
                if ((crit_diff >= FlySpeed - NormalSpeed) && (Startle != null))
                {
                    Startle(this, new BirdEventsArgs(Nick.ToString() + "panic..."));
                }
                if (NormalSpeed >= FlySpeed)
                {
                    BirdFlewAway = true;
                }
                else
                {
                    Console.WriteLine("...flying close with the speed = {0}", NormalSpeed);
                }

            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird(15, 1);
            bird.FlyAway(2);
        }
    }
}
