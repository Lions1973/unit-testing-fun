using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApplication1.BusinessObjects;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarBLL_NoSetup_CarGoes()
        {
            //Arrang
            var myBll = new MockCarBLL();

            //Act
            Car mCar = myBll.GetCarFromDB();
            mCar.Drift();

            //Assert
            Assert.IsTrue(mCar.IsDrifting);
        }

    }
}
