using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models;

namespace opcUaWebMVC;

public sealed class ApplicationContext : DbContext
{
    private const string DB_IP = "192.168.1.13";
    private const string DB_USER = "alexey";
    private const string DB_PASSWORD = "Y8D5H9Z1X3";
    private const string DB_NAME = "opc";
    
    public DbSet<User> Users { get; set; } = null!;
    
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql($"server={DB_IP};user={DB_USER};password={DB_PASSWORD};database={DB_NAME};", 
            new MySqlServerVersion(new Version(8, 0, 25)));
    }
}