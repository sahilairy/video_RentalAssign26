using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace video_RentalAssign26Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            video_RentalAssign26.RentalOperation obj = new video_RentalAssign26.RentalOperation();
            int x = obj.getCopies(1);
            if (x > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            video_RentalAssign26.RentalOperation obj = new video_RentalAssign26.RentalOperation();
            int x = obj.getCost(1);
            if (x ==2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}
