using System.Collections.Generic;

namespace HeboTech.Fruits
{
    public class UnauthorizedResult<T> : Result<T>
    {
        public UnauthorizedResult(string error)
            : base(ResultType.Unauthorized, error)
        {
        }

        public UnauthorizedResult(IEnumerable<string> errors)
            : base(ResultType.Unauthorized, errors)
        {
        }
    }
}
