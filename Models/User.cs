using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models;

[Table("user")]
public class User
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("login")] public string login { get; set; }
    [Column("password")] public string passwd { get; set; }

    [Column("is_admin")] public bool isAdmin { get; set; }

    public User(string name, string login, string passwd, bool isAdmin)
    {
        this.name = name;
        this.login = login;
        this.passwd = passwd;
        this.isAdmin = isAdmin;
    }
}