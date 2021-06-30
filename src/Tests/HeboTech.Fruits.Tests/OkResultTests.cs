using Xunit;

namespace HeboTech.Fruits.Tests
{
    public class OkResultTests
    {
        [Fact]
        public void Null_sets_data_test()
        {
            OkResult<object> result = new(null);

            Assert.Equal(ResultType.Ok, result.ResultType);
            Assert.Equal(0, result.Errors.Count);
            Assert.Null(result.Data);
        }

        [Fact]
        public void Data_is_set_test()
        {
            object data = new();
            OkResult<object> result = new(data);

            Assert.Equal(ResultType.Ok, result.ResultType);
            Assert.Equal(0, result.Errors.Count);
            Assert.Equal(data, result.Data);
        }
    }
}
