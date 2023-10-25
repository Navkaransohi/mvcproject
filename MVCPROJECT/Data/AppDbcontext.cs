
using Microsoft.EntityFrameworkCore;
using MVCPROJECT.Models;

namespace MVCPROJECT.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {
            
        }

        public DbSet<Artist> Artist { get; set; }
    }
}