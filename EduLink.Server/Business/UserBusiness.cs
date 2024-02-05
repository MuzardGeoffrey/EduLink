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

        public async Task<User> Create(User user)
        {
            if(await this._context.Users.AnyAsync(x => x.Email == user.Email)){
                                throw new System.Exception("Email \"" + user.Email + "\" is already taken");
            }else if(await this._context.Users.AnyAsync(x => x.Pseudo == user.Pseudo)){
                                throw new System.Exception("Pseudo \"" + user.Pseudo + "\" is already taken");
            }
            else
            {
                await this.CreateOrUpdate(user);
                return user;
            }
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
            bool isExist = await _context.Users.AnyAsync(u => u.Email == email && u.Password == password);

            return isExist;
        }
    }
}