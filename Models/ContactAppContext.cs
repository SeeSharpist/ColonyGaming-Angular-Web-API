using Microsoft.EntityFrameworkCore;

namespace ColonyGaming_Angular_Web_API.Models
{
    public class ContactAppContext : DbContext
    {
          public ContactAppContext(DbContextOptions<ContactAppContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }

    }
}