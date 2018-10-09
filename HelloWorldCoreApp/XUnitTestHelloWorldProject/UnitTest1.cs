using System;
using Xunit;
using HelloWorldAPIConsumer;

namespace XUnitTestHelloWorldProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestReadingDatefromConfig()
        {
            var sut = Program.Display();
            Assert.Equal("Hello World Crowe..!!", sut);
        }

        [Fact]
        public void NullCheck()
        {
            var sut = Program.Display();
            Assert.NotNull(sut);
        }

        [Fact]
        public void NegativeCaseTest1()
        {
            var sut = Program.Display();
            Assert.NotEqual("Hello World", sut);
        }
    }
}
