namespace opcUaWebMVC.Models;

public class User
{
    public string name;
    public string login;
    public string passwd;

    public User(string name, string login, string passwd)
    {
        this.name = name;
        this.login = login;
        this.passwd = passwd;
    }
}