using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace lab2_z3Test
{
    [TestClass]
    public class Usings
    {
        [TestMethod]
        public void TestMethod1()
        {

            int[] b = { 1, -2, 3, -4, 5 };

            double expectedDob = 8;
            double actualDob = lab2_z3.Program.Dob(b);
            Assert.AreEqual(expectedDob, actualDob);

            int expectedSum = 5;
            int actualSum = lab2_z3.Program.Sum(b);
            Assert.AreEqual(expectedSum, actualSum);

        }
    }
}
