namespace webapi.IBusiness
{
    using webapi.Object;

    public interface IUserBusiness : IBaseBusiness<User>
    {
        public Task<List<User>> List();

        public Task<User?> Details(int id);

        public Task<int> Login(string email, string password);
        public Task<User> Create(User user);
        Task<User?> Update(User user);
        Task<User?> UpdateWithPassword(User user);
    }
}