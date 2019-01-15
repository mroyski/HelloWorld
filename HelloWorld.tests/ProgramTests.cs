using System;
using Xunit;

namespace HelloWorld.tests
{
    public class ProgramTests
    {
        [Fact]
        public void Hello_World_Test()
        {
            Assert.Equal("Hello", "Hello");
        }
    }
}
