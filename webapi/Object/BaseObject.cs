namespace webapi.Object
{
    using Microsoft.EntityFrameworkCore;

    public abstract class BaseObject : DbContext
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}