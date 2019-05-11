using System;
using Xunit;

namespace jsonValidator

{
    public class ProgramTest
    {
        [Fact]
        public void JSONThatStartsAndEndsWithQuotationmarks()
        {
            var v = "\"This is a Json\"";
            bool expected = true;
            bool actual = Program.ValidateJson(v);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void JSONThatStartsAndEndsWithQuotationmarksAndContainsOtherUNICODEChars()
        {
            var v = "\"Test\\u0097\nAnother line\"";
            bool expected = true;
            bool actual = Program.ValidateJson(v);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void JSONThatOnlyEndsWithQuotationmarks()
        {
            var v = "Test\"";
            bool expected = false;
            bool actual = Program.ValidateJson(v);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void JSONThatOnlyStartsWithQuotationmarks()
        {
            var v = "\"Test";
            bool expected = false;
            bool actual = Program.ValidateJson(v);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void JSONWithQuotationMarksAtStartMiddleAndEnd()
        {
            var v = "\"Te\"st\"";
            bool expected = false;
            bool actual = Program.ValidateJson(v);
            Assert.Equal(expected, actual);
        }
    }
}
