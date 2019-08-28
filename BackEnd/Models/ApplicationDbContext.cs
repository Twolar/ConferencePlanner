using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models {

    /// <summary>
    /// Connection object for database
    /// </summary>
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) {
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}