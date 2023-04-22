using Microsoft.EntityFrameworkCore;

namespace L01P02_2019_MZ_602.Models
{
    public class blogDbContextClass : DbContext
    {
        public blogDbContextClass(DbContextOptions options) : base(options) { } 

        public DbSet<usuarios> usuarios { get; set; }   
    }
}
