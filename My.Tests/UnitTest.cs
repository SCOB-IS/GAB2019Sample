using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace My.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // ARRANGE //
            const int Expected = 2;

            // ACT //
            int Actual = 1 + 1;

            // ASSERT //
            Assert.AreEqual(Expected, Actual);
        }
    }
}
