using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC;

public sealed class ApplicationContext : DbContext
{
    private const string DB_IP = "192.168.1.103";
    private const string DB_USER = "alexey";
    private const string DB_PASSWORD = "Y8D5H9Z1X3";
    private const string DB_NAME = "opcTest";

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Plc> Plcs { get; set; } = null!;
    public DbSet<Location> Locations { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseMySql($"server={DB_IP};user={DB_USER};password={DB_PASSWORD};database={DB_NAME};",
        //     new MySqlServerVersion(new Version(10, 6, 16)));

        optionsBuilder.UseMySql($"server={DB_IP};user={DB_USER};password={DB_PASSWORD};database={DB_NAME};",
            new MariaDbServerVersion("10.6.16"));
    }
}