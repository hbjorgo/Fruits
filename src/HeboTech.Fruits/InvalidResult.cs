using System.Collections.Generic;

namespace HeboTech.Fruits
{
    public class InvalidResult<T> : Result<T>
    {
        public InvalidResult(string error)
            : base(ResultType.Invalid, error)
        {
        }

        public InvalidResult(IEnumerable<string> errors)
            : base(ResultType.Invalid, errors)
        {
        }
    }
}
