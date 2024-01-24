namespace webapi.Object
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public class User(string firstName, string lastName, string email, string password, string pseudo) : BaseObject
    {
        [Required]
        public string FirstName { get; set; } = firstName;

        [Required]
        public string LastName { get; set; } = lastName;

        [Required]
        public string Email { get; set; } = email;

        [Required]
        public string Password { get; set; } = password;

        [Required]
        public string Pseudo { get; set; } = pseudo;

        public string PseudoShortened => Pseudo[..3];

        public List<Subject>? Subjects { get; set; }
    }
}