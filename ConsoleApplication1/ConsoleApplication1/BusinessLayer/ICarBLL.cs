using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApplication1.BusinessObjects;

namespace ConsoleApplication1.BusinessLayer
{
    public interface ICarBLL
    {
        Car GetCarFromDB();
    }
}
