namespace webapi.DataAccess.Seed
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}