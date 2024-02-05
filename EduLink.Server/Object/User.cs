namespace webapi.Object
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public class User() : BaseObject
    {
        public User(string firstName, string lastName, string email, string password, string pseudo) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Pseudo = pseudo;
        }

        public User(int id, string firstName, string lastName, string email, string password, string pseudo) : this(firstName, lastName, email, password, pseudo)
        {
            this.Id = id;
            this.CreatedDate = DateTime.Now;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }

        public string Pseudo { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}