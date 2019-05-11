using System;
using Xunit;

namespace jsonValidator

{
    public class ProgramTest
    {
        [Fact]
        public void FirstGreenTest()
        {
            bool expected = true;
            bool actual = Program.ValidateJson();
            Assert.Equal(expected, actual);
        }
    }
}
