namespace HeboTech.Fruits
{
    public class OkResult<T> : Result<T>
    {
        public OkResult(T data)
            : base(ResultType.Ok, data)
        {
        }
    }
}
