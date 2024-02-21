namespace webapi.Business
{
    using Microsoft.EntityFrameworkCore;
    using webapi.DataAccess;
    using webapi.IBusiness;
    using webapi.Object;

    public class UserBusiness(DataContext context) : BaseBusiness<User>(context), IUserBusiness
    {
        public async Task<User> Create(User user)
        {
            if (await this._context.Users.AnyAsync(x => x.Email == user.Email))
            {
                throw new System.Exception("Email \"" + user.Email + "\" is already taken");
            }
            else if (await this._context.Users.AnyAsync(x => x.Pseudo == user.Pseudo))
            {
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

        public async Task<User?> UpdateWithPassword(User user)
        {
            if (user != null && user != default && this.Get(user.Id) != null)
            {
                User? userToUpdate = this._context.Users.Find(user.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.FirstName = user.FirstName;
                    userToUpdate.LastName = user.LastName;
                    userToUpdate.Email = user.Email;
                    userToUpdate.Pseudo = user.Pseudo;
                    userToUpdate.Password = user.Password;
                    userToUpdate.LastUpdateDate = DateTime.Now;
                    userToUpdate.Subjects = user.Subjects;
                    this._context.Update(userToUpdate);
                    await this._context.SaveChangesAsync();
                    return userToUpdate;
                }
            }
            return user;
        }

        public async Task<User?> Update(User user)
        {
            if (user != null && user != default && this.Get(user.Id) != null)
            {
                User? userToUpdate = this._context.Users.Find(user.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.FirstName = user.FirstName;
                    userToUpdate.LastName = user.LastName;
                    userToUpdate.Email = user.Email;
                    userToUpdate.Pseudo = user.Pseudo;
                    userToUpdate.LastUpdateDate = DateTime.Now;
                    userToUpdate.Subjects = user.Subjects;
                    this._context.Update(userToUpdate);
                    await this._context.SaveChangesAsync();
                    return userToUpdate;
                }
            }
            return user;
        }

        public async Task<User?> Details(int id)
        {
            User? user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);

            return user;
        }

        public async Task<int> Login(string email, string password)
        {
            int userId = await _context.Users.Where(u => u.Email == email && u.Password == password).Select(u => u.Id).FirstOrDefaultAsync();

            return userId;
        }
    }
}