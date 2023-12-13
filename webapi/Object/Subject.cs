namespace webapi.Object
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Subject")]
    [PrimaryKey(nameof(EnumSubject), nameof(Level), nameof(Id))]
    public class Subject : BaseObject
    {
        public EnumSubject EnumSubject { get; private set; }
        public short Level { get; set; }

        public List<User> Users { get; set; }

        public Subject(EnumSubject enumSubject)
        {
            this.Set(enumSubject);
        }

        public Subject(EnumSubject enumSubject, short level) : this(enumSubject)
        {
            this.Level = level;
        }

        public Subject(EnumSubject enumSubject, short level, int id) : this(enumSubject, level)
        {
            this.Id = id;
            this.CreatedDate = DateTime.Now;
        }

        public Subject Set(EnumSubject enumSubject)
        {
            this.EnumSubject = enumSubject;
            return this;
        }
    }

    public enum EnumSubject : short
    {
        ENGLISH,
        MATH,
        HISTORY,
        GEOGRAPHY,
        SCIENCE,
        PHYSICS,
        CHEMISTRY,
        BIOLOGY,
        PHILOSOPHY,
        ART,
        MUSIC,
        SPORT,
        COMPUTER_SCIENCE,
        FRENCH,
        SPANISH,
    }
}