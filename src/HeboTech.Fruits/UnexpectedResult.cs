using System.Collections.Generic;

namespace HeboTech.Fruits
{
    public class UnexpectedResult<T> : Result<T>
    {
        public UnexpectedResult(string error)
            : base(ResultType.Unexpected, error)
        {
        }

        public UnexpectedResult(IEnumerable<string> errors)
            : base(ResultType.Unexpected, errors)
        {
        }
    }
}
