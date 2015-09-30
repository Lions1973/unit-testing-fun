using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApplication1.BusinessObjects;
using ConsoleApplication1.DataLayer;

namespace ConsoleApplication1.BusinessLayer
{
    public class CarBLL : ICarBLL
    {
        public Car GetCarFromDB()
        {
            return new CarDAL().GetCarFromDatabase();
        }
    }
}
