namespace webapi.DataAccess.Seed
{
    using Microsoft.EntityFrameworkCore;
    using webapi.Object;

    public class SubjectSeed
    {
        public static void GenerateData(ModelBuilder modelBuilder)
        {
            int i = 1;
            foreach (EnumSubject subject in Enum.GetValues(typeof(EnumSubject)))
            {
                for (short y = 3; y <= 6; y++)
                {
                    modelBuilder.Entity<Subject>().HasData(
                       new Subject(subject, y, i));
                    i++;
                }
            }
        }
    }
}