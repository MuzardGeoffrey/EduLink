namespace webapi.Object
{
    public class Subject
    {
        public string Name { get; private set; }
        public EnumSubject EnumSubject { get; private set; }
        public Level Level { get; private set; }

        public Subject(EnumSubject enumSubject, int level)
        {
            this.Set(enumSubject);
            this.Level = new(level);
        }

        public Subject Set(EnumSubject enumSubject)
        {
            this.Name = enumSubject.ToString();
            this.EnumSubject = enumSubject;
            return this;
        }

        public Level Set(int level)
        {
            this.Level.Set(level);
            return this.Level;
        }
    }

    public enum EnumSubject
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