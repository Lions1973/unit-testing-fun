using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.BusinessObjects
{
    public class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("Vehicle is going");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }
    }
}
