using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HeboTech.Fruits.Tests
{
    public class InvalidResultTests
    {
        [Fact]
        public void Null_string_sets_defaults_test()
        {
            InvalidResult<object> result = new((string)null);

            Assert.Equal(ResultType.Invalid, result.ResultType);
            Assert.Equal(0, result.Errors.Count);
            Assert.Null(result.Data);
        }

        [Fact]
        public void String_sets_errors_test()
        {
            InvalidResult<object> result = new("Error");

            Assert.Equal(ResultType.Invalid, result.ResultType);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal("Error", result.Errors.ElementAt(0));
            Assert.Null(result.Data);
        }

        [Fact]
        public void Null_list_sets_defaults_test()
        {
            InvalidResult<object> result = new((List<string>)null);

            Assert.Equal(ResultType.Invalid, result.ResultType);
            Assert.Equal(0, result.Errors.Count);
            Assert.Null(result.Data);
        }

        [Fact]
        public void List_sets_errors_test()
        {
            InvalidResult<object> result = new(new List<string> { "Error1", "Error2" });

            Assert.Equal(ResultType.Invalid, result.ResultType);
            Assert.Equal(2, result.Errors.Count);
            Assert.Equal("Error1", result.Errors.ElementAt(0));
            Assert.Equal("Error2", result.Errors.ElementAt(1));
            Assert.Null(result.Data);
        }
    }
}
