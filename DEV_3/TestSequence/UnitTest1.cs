using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_3;

namespace TestSequence
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetChangedString1()
        {
            Sequence sequence = new Sequence("");
            Assert.AreEqual<string>("", sequence.GetChangedString());
        }
        [TestMethod]
        public void TestGetChangedString2()
        {
            Sequence sequence = new Sequence("abc");
            Assert.AreEqual<string>("������", sequence.GetChangedString());
        }
        [TestMethod]
        public void TestGetChangedString3()
        {
            Sequence sequence = new Sequence("2019");//Exception must be here
        }
    }
}
