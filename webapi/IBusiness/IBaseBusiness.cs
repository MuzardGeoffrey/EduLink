namespace webapi.IBusiness
{
    using webapi.Object;

    public interface IBaseBusiness<T> : IDisposable
    {
        public Task<T?> Get(int id);

        public Task<T> CreateOrUpdate(T t);

        public Task<bool> Delete(int id);
    }
}