using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.BusinessObjects
{
    public class Car : Vehicle, IDriftable
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public List<Wheel> Wheels { get; set; }

        public Engine Engine { get; set; }

        private bool isDrifting;

        public bool IsDrifting
        {
            get
            {
                return isDrifting;
            }
        }

        //public override void Go()
        //{
        //    Console.WriteLine("Car is going");
        //}

        //public override void Stop()
        //{
        //    Console.WriteLine("Car is stopping");
        //}

        public void Drift()
        {
            Console.WriteLine("Car is drifting!!");
            isDrifting = true;
        }
    }
}
