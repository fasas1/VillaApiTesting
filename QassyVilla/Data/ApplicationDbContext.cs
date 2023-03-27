using Microsoft.EntityFrameworkCore;
using QassyVilla.Models;

namespace QassyVilla.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
