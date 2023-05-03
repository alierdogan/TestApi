namespace TestApi
{
    public class Result<TEntity> where TEntity : class, new()
    {
        public string Status { get; set; }
        public string Error { get; set; }
        public TEntity Data { get; set; }
    }
}
