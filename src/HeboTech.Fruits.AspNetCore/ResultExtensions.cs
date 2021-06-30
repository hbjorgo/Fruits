using Microsoft.AspNetCore.Mvc;
using System;

namespace HeboTech.Fruits.AspNetCore
{
    public static class ResultExtensions
    {
        /// <summary>
        /// Creates an ActionResult from a result
        /// </summary>
        /// <typeparam name="T">The result data type</typeparam>
        /// <param name="result">The result</param>
        /// <returns></returns>
        public static ActionResult FromResult<T>(this ControllerBase controller, Result<T> result)
        {
            return result.ResultType switch
            {
                ResultType.Ok => controller.Ok(result.Data),
                ResultType.NoContent => controller.NoContent(),
                ResultType.NotFound => controller.NotFound(result.Errors),
                ResultType.Unauthorized => controller.Unauthorized(result.Errors),
                ResultType.Invalid => controller.BadRequest(result.Errors),
                ResultType.Unexpected => controller.StatusCode(500, result.Errors),
                _ => throw new ArgumentException($"Unhandled result type: {result.ResultType}")
            };
        }
    }
}
