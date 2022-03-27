using Microsoft.EntityFrameworkCore;

namespace viggoWebApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Character> characters {get; set;}
    }
}