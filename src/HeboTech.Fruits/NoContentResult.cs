namespace HeboTech.Fruits
{
    public class NoContentResult<T> : Result<T>
    {
        public NoContentResult()
            : base(ResultType.NoContent)
        {
        }
    }
}
