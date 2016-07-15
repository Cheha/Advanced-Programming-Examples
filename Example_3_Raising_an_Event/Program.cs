using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Raising_an_Event
{
    public class Bird
    {
        public class BirdEventsArgs
        { 
            public readonly string mess;
            public BirdEventsArgs(string str_mess)
            {
                mess = str_mess;
            }
        }

        public delegate void BirdEventsHandler(object sender, BirdEventsArgs e);
        public event BirdEventsHandler NotSeeing;

        public bool BirdFlewAway { get; set; }

        protected virtual void OnNotSeeing(BirdEventsArgs e)
        {
            BirdEventsHandler handler = NotSeeing;
            if(handler != null)
            {
                handler(this, e);
            }
        }

        public void FlyAway(int increment)
        {
            if (BirdFlewAway)
            { 
                
            }
        
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
        }
    }
}
