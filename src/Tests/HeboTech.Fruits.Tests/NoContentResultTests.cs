using Xunit;

namespace HeboTech.Fruits.Tests
{
    public class NoContentResultTests
    {
        [Fact]
        public void Constructor_sets_defaults_test()
        {
            NoContentResult<object> result = new();

            Assert.Equal(ResultType.NoContent, result.ResultType);
            Assert.Equal(0, result.Errors.Count);
            Assert.Null(result.Data);
        }
    }
}
