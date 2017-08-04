using NUnit.Framework;
using System;
using SparkleSharpSample;
namespace SparkleSharpSample.NUnit.Test
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            var n = new NewEmptyClass();
            Assert.AreEqual("hoge", n.GetString());
        }
    }
}
