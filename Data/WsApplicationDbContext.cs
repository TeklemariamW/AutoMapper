using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

public class WsApplicationDbContext : DbContext
{
    public WsApplicationDbContext(DbContextOptions<WsApplicationDbContext> options)
        : base(options)
        {}

    public DbSet<Pizza>? pizzas { get; set; }
    //public DbSet<Command>? commands { get; set; }
    public DbSet<Command>? commands { get; set; }
}