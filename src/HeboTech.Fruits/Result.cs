using System.Collections.Generic;

namespace HeboTech.Fruits
{
    public abstract class Result<T>
    {
        private readonly List<string> _errors = new();

        public Result(ResultType resultType)
        {
            ResultType = resultType;
        }

        public Result(ResultType resultType, T data)
        {
            ResultType = resultType;
            Data = data;
        }

        public Result(ResultType resultType, string error)
        {
            ResultType = resultType;
            if (error != default)
                _errors.Add(error);
        }

        public Result(ResultType resultType, IEnumerable<string> errors)
        {
            ResultType = resultType;
            if (errors != default)
                _errors.AddRange(errors);
        }

        public ResultType ResultType { get; }
        public IReadOnlyCollection<string> Errors => _errors.AsReadOnly();
        public T Data { get; } = default;
    }
}
