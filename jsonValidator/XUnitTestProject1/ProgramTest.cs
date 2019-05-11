using System;
using Xunit;

namespace jsonValidator

{
    public class ProgramTest
    {
        [Fact]
        public void FailingTest_MethodNotImplemented()
        {
            Program.ValidateJson();
        }
    }
}
