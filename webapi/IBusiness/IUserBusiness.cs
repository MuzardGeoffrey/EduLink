namespace webapi.IBusiness
{
    using webapi.Object;

    public interface IUserBusiness : IBaseBusiness<User>
    {
        public Task<List<User>> List();

        public Task<User?> Details(int id);
    }
}