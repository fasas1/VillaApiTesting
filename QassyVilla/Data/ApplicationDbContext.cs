using Microsoft.EntityFrameworkCore;
using QassyVilla.Models;

namespace QassyVilla.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
        public DbSet<Villa> Villas { get; set; }
    }
}
