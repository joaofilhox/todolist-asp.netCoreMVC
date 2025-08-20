using Microsoft.EntityFrameworkCore;
using TWTodoList.EntityConfigs;
using TWTodoList.Models;

namespace TWTodoList.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=TWTTodoList;User Id=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TodoEntityConfig());
    }
}
