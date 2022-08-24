using SimpleConsoleApp2;

namespace TestCalculator
{
    [TestClass]
    public static class testcalculator
    {
        [TestMethod]
        public static void TestMethod1()
        {
            calculator c = new calculator();
            int result = c.add(10, 20);
            Assert.AreEqual(10, result);
        }
    }
}