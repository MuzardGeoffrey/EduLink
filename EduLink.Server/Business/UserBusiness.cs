namespace webapi.Business
{
    using Microsoft.EntityFrameworkCore;
    using webapi.DataAccess;
    using webapi.IBusiness;
    using webapi.Object;

    public class UserBusiness : BaseBusiness<User>, IUserBusiness
    {
        public UserBusiness(DataContext context) : base(context)
        {
        }

        public async Task<List<User>> List()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> Details(int id)
        {
            User? user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);

            return user;
        }

        public async Task<bool> Login(string email, string password)
        {
            bool isExist = await _context.Users
                .Where(u => u.Email == email && u.Password == password).AnyAsync();

            return isExist;
        }
    }
}