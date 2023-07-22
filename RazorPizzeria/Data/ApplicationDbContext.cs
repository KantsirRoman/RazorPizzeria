using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Model;

namespace RazorPizzeria.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<PizzaOrder> PizzaOrder { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
            
    }
}