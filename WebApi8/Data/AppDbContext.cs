using Microsoft.EntityFrameworkCore;

namespace WebApi8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base (options)
        {  
        }
    }
}
