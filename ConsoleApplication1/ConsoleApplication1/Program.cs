using System;

using ConsoleApplication1.BusinessLayer;
using ConsoleApplication1.BusinessObjects;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new CarBLL().GetCarFromDB();
            myCar.Go();
            myCar.Drift();
        }
    }
}
