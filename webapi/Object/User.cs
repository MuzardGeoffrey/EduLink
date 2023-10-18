namespace webapi.Object
{
    public class User : BaseObject
    {
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public Pseudo Pseudo { get; private set; }
        public Subject MainSubject { get; private set; }

        public User(Name name, Email email, string password, Pseudo pseudo, Subject mainSubject)
        {
            Name = name;
            Email = email;
            Password = password;
            Pseudo = pseudo;
            MainSubject = mainSubject;
        }

        public User(Name name, string email, string password, string pseudo, EnumSubject mainSubject, int level)
        {
            Name = name;
            Email = new Email(email);
            Password = password;
            Pseudo = new Pseudo(pseudo);
            MainSubject = new Subject(mainSubject, level);
        }

        public Name SetName(string first, string last)
        {
            Name = new Name(first, last);
            return Name;
        }

        public Name SetName(Name name)
        {
            Name = name;
            return Name;
        }

        public Email SetEmail(string email)
        {
            Email = new Email(email);
            return Email;
        }

        public Email SetEmail(Email email)
        {
            Email = email;
            return Email;
        }

        public string SetPassword(string password)
        {
            Password = password;
            return Password;
        }

        public Pseudo SetPseudo(string pseudo)
        {
            Pseudo = new Pseudo(pseudo);
            return Pseudo;
        }

        public Pseudo SetPseudo(Pseudo pseudo)
        {
            Pseudo = pseudo;
            return Pseudo;
        }

        public Subject SetMainSubject(Subject mainSubject)
        {
            MainSubject = mainSubject;
            return MainSubject;
        }

        public Subject SetMainSubject(EnumSubject mainSubject, int level)
        {
            MainSubject = new Subject(mainSubject, level);
            return MainSubject;
        }

        public Subject SetMainSubject(EnumSubject mainSubject)
        {
            MainSubject.Set(mainSubject);
            return MainSubject;
        }

        public Level SetMainSubjectLevel(int level)
        {
            MainSubject.Set(level);
            return MainSubject.Level;
        }
    }
}