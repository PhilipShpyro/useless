using NUnit.Framework;
using DEV_7;
using System;

namespace Tests
{
    public class Tests
    {
        Invoker invoker;

        [OneTimeSetUp]
        public void Setup()
        {
            invoker = new Invoker();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(invoker.GetResult("2 + 2 ="), "4");
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(invoker.GetResult("2 - 2 ="), "0");
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(invoker.GetResult("2 * 2 ="), "4");
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(invoker.GetResult("2 / 2 ="), "1");
        }
        [Test]
        public void Test5()
        {
            int n = 1;
            invoker.ChangeAgterDotLength(n);
            Assert.AreEqual(n, invoker.GetAfterDotLength());
        }
        [Test]
        public void Test6()
        {
            int n = 12;
            invoker.ChangeAgterDotLength(n);
            Assert.AreEqual(n, invoker.GetAfterDotLength());
        }
        [Test]
        public void Test7()
        {
            int n = 5;
            invoker.ChangeAgterDotLength(n);
            Assert.AreEqual(n, invoker.GetAfterDotLength());
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            invoker.ClosePage();
        }
    }
}