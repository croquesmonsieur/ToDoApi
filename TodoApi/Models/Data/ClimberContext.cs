using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models.Data
{
    public class ClimberContext : DbContext
    {
       
            public ClimberContext(DbContextOptions<Data.ClimberContext> options)
                : base(options)
            {
            }

            public DbSet<Climbers> Climbers { get; set; }
        
    }
}