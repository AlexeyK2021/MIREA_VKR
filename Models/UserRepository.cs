namespace opcUaWebMVC.Models;

public static class UserRepository
{
    public static List<User> users = new()
    {
        new User("alexey", "alexey", "12345"),
        new User("ivan", "ivan", "1234")
    };
}
