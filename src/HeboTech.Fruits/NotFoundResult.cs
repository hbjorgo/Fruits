using System.Collections.Generic;

namespace HeboTech.Fruits
{
    public class NotFoundResult<T> : Result<T>
    {
        public NotFoundResult(string error)
            : base(ResultType.NotFound, error)
        {
        }

        public NotFoundResult(IEnumerable<string> errors)
            : base(ResultType.NotFound, errors)
        {
        }
    }
}
