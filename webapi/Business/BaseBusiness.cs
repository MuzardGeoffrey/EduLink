namespace webapi.Business
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using webapi.DataAccess;
    using webapi.IBusiness;
    using webapi.Object;

    public abstract class BaseBusiness<T> : IBaseBusiness<T> where T : BaseObject
    {
        protected readonly DataContext _context;

        public BaseBusiness(DataContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
        }

        public async Task<T?> Get(int id)
        {
            T? user = await _context.FindAsync<T>(id);

            return user;
        }

        public async Task<T> CreateOrUpdate(T t)
        {
            if (t != null && this.Get(t.Id) != null)
            {
                _context.Update(t);
            }
            else
            {
                _context.Add<T>(t);
            }

            await _context.SaveChangesAsync();

            return t;
        }

        public async Task<bool> Delete(int id)
        {
            T? t = await this.Get(id);

            if (t != null)
            {
                _context.Remove<T>(t);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}