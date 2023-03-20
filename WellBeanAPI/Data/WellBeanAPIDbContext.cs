using Microsoft.EntityFrameworkCore;
using WellBeanAPI.Models;

namespace WellBeanAPI.Data
{
    public class WellBeanAPIDbContext : DbContext
    {
       public WellBeanAPIDbContext(DbContextOptions options) : base(options)
        {

        } 
        
       public DbSet<Survey> Surveys { get; set; }
    }
}
