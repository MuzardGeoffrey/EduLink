namespace EduLink.Server.DataAccess.Seed
{
    using Microsoft.EntityFrameworkCore;
    using webapi.Object;

    public class UserSeed
    {
        public static void GenerateData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                       new User(1, "PrenomDeTest", "NomDeTest", "Email@de.Test", "test", "PseudoDeTest"));
        }
    }
}