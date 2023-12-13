namespace webapi.Object
{
    using Microsoft.Build.Framework;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public class User : BaseObject
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Pseudo { get; set; }

        public string PseudoShortened => Pseudo[..3];

        public List<Subject> Subjects { get; set; }

        public User(string firstName, string lastName, string email, string password, string pseudo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Pseudo = pseudo;
        }
    }
}