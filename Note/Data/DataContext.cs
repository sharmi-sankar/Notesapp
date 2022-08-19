using Microsoft.EntityFrameworkCore;
using Note.Model;

namespace Note.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {

        }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Model.Version> Versions { get; set; }
    }
}
