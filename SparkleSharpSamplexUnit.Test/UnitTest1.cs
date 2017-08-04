using System;
using Xunit;
using SparkleSharpSample;

namespace SparkleSharpSamplexUnit.Test
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
