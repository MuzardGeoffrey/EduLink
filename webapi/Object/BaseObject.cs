namespace webapi.Object
{
    using Microsoft.EntityFrameworkCore;

    public abstract class BaseObject
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}