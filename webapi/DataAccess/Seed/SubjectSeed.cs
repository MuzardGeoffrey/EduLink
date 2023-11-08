namespace webapi.DataAccess.Seed
{
    using Microsoft.EntityFrameworkCore;
    using webapi.Object;

    public class SubjectSeed
    {
        public static void GenerateData(ModelBuilder modelBuilder)
        {
            foreach (EnumSubject subject in Enum.GetValues(typeof(EnumSubject)))
            {
                for (short i = 3; i <= 6; i++)
                {
                    modelBuilder.Entity<Subject>().HasData(
                       new Subject(subject, i));
                }
            }
        }
    }
}