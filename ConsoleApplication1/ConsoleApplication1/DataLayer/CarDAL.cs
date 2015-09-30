using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApplication1.BusinessObjects;

namespace ConsoleApplication1.DataLayer
{
    public class CarDAL
    {
        public Car GetCarFromDatabase()
        {
            //go to database and return a new car 
            return new Car
                   {
                       Engine = new Engine(),
                       Make = "Jaguar",
                       Model = "E-Type",
                       Year = "1960",
                       Wheels = new List<Wheel>()
                   };
        }
    }
}
