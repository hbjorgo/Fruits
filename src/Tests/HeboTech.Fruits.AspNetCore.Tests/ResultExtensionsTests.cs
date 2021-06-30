using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Linq;
using Xunit;

namespace HeboTech.Fruits.AspNetCore.Tests
{
    public class ResultExtensionsTests
    {
        [Fact]
        public void InvalidResult_returns_BadRequestObjectResult_test()
        {
            TestController testController = new();
            InvalidResult<object> result = new("Error");

            var actionResult = testController.FromResult(result);

            Assert.NotNull(actionResult);
            Assert.Equal(typeof(BadRequestObjectResult), actionResult.GetType());
            Assert.Equal(typeof(ReadOnlyCollection<string>), ((BadRequestObjectResult)actionResult).Value.GetType());
            Assert.Equal("Error", ((ReadOnlyCollection<string>)((BadRequestObjectResult)actionResult).Value).ElementAt(0));
        }

        [Fact]
        public void NoContentResult_returns_NoContentResult_test()
        {
            TestController testController = new();
            NoContentResult<object> result = new();

            var actionResult = testController.FromResult(result);

            Assert.NotNull(actionResult);
            Assert.Equal(typeof(NoContentResult), actionResult.GetType());
        }

        [Fact]
        public void NotFoundResult_returns_NotFoundObjectResult_test()
        {
            TestController testController = new();
            NotFoundResult<object> result = new("Error");

            var actionResult = testController.FromResult(result);

            Assert.NotNull(actionResult);
            Assert.Equal(typeof(NotFoundObjectResult), actionResult.GetType());
            Assert.Equal(typeof(ReadOnlyCollection<string>), ((NotFoundObjectResult)actionResult).Value.GetType());
            Assert.Equal("Error", ((ReadOnlyCollection<string>)((NotFoundObjectResult)actionResult).Value).ElementAt(0));
        }

        [Fact]
        public void OkResult_returns_OkObjectResult_test()
        {
            TestController testController = new();
            object data = new();
            OkResult<object> result = new(data);

            var actionResult = testController.FromResult(result);

            Assert.NotNull(actionResult);
            Assert.Equal(typeof(OkObjectResult), actionResult.GetType());
            Assert.Equal(data, ((OkObjectResult)actionResult).Value);
        }

        [Fact]
        public void UnauthorizedResult_returns_UnauthorizedObjectResult_test()
        {
            TestController testController = new();
            UnauthorizedResult<object> result = new("Error");

            var actionResult = testController.FromResult(result);

            Assert.NotNull(actionResult);
            Assert.Equal(typeof(UnauthorizedObjectResult), actionResult.GetType());
            Assert.Equal(typeof(ReadOnlyCollection<string>), ((UnauthorizedObjectResult)actionResult).Value.GetType());
            Assert.Equal("Error", ((ReadOnlyCollection<string>)((UnauthorizedObjectResult)actionResult).Value).ElementAt(0));
        }

        [Fact]
        public void UnexpectedResult_returns_bad_request_test()
        {
            TestController testController = new();
            UnexpectedResult<object> result = new("Error");

            var actionResult = testController.FromResult(result);

            Assert.NotNull(actionResult);
            Assert.Equal(typeof(ObjectResult), actionResult.GetType());
            Assert.Equal(500, ((ObjectResult)actionResult).StatusCode);
            Assert.Equal(typeof(ReadOnlyCollection<string>), ((ObjectResult)actionResult).Value.GetType());
            Assert.Equal("Error", ((ReadOnlyCollection<string>)((ObjectResult)actionResult).Value).ElementAt(0));
        }
    }
}
