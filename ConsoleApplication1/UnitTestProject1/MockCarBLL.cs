using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApplication1.BusinessLayer;
using ConsoleApplication1.BusinessObjects;

namespace UnitTestProject1
{
    class MockCarBLL : ICarBLL
    {
        public Car GetCarFromDB()
        {
            return new Car
                   {
                       Make = "Toyota",
                       Model = "Corolla",
                       Year = "1980",
                       Engine = null,
                       Wheels = new List<Wheel>()
                   };
        }
    }
}
