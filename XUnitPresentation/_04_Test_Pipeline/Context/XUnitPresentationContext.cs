using System.Data.Entity;
using __NAME__.Models;

namespace __NAME__.Models
{
    public class XUnitPresentationContext : DbContext
    {
        public XUnitPresentationContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}