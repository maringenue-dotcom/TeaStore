using Microsoft.EntityFrameworkCore;
using TeaStoreApi.Models;

namespace TeaStoreApi.Context
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options):base(options) { }

        public DbSet<Teas> Teas { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
