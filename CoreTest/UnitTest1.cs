using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcCore;
namespace CoreTest
{
    [TestClass]
    public class UnitTest1
    {
        Program obj = new Program();  
        [TestMethod]
        
        public void TestMethod1()
        {
            int actual = obj.add(5, 4);
            int expected = 9;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]

        public void TestMethod2()
        {
            int actual = obj.sub(5, 4);
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]

        public void TestMethod3()
        {
            int actual = obj.multiply(5, 4);
            int expected = 20;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]

        public void TestMethod4()
        {
            int actual = obj.divide(5, 5);
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }
    }
}
