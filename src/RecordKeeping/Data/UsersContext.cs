using Microsoft.EntityFrameworkCore;

namespace RecordKeeping.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
