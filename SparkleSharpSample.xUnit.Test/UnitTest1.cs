using System;
using Xunit;

namespace SparkleSharpSample.xUnit.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var s = new EmptyClass();
            Assert.Equal("hoge", s.GetString());
        }
    }
}
