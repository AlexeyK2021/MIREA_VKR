using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models;

namespace opcUaWebMVC;

public sealed class ApplicationContext : DbContext
{
    private const string DB_IP = "192.168.1.5";
    private const string DB_USER = "opc";
    private const string DB_PASSWORD = "OPC12345";
    private const string DB_NAME = "opcTest";
    
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