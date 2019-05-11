using System;
using Xunit;

namespace jsonValidator

{
    public class ProgramTest
    {
        [Fact]
        public void ASimpleJson()
        {
            var v = "\"This is a Json\"";
            bool expected = true;
            bool actual = Program.ValidateJson(v);
            Assert.Equal(expected, actual);
        }
    }
}
