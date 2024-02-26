namespace opcUaWebMVC;

public static class Logger
{
    public static void debug(string tag, string value)
    {
        Console.WriteLine($"{tag} - {value}");
    }

    public static void param(int paramId, float value, int locationId)
    {
        //TODO
        // using (ApplicationContext db = new ApplicationContext())
        // {
        //     db.parameterLogs.Add(new ParameterLog());
        //     db.SaveChanges();
        // }
    }

    public static void system(string tag, string value)
    {
        //TODO
        // using (ApplicationContext db = new ApplicationContext())
        // {
        //     db.actionLogs.Add(new ActionLog());
        //     db.SaveChanges();
        // }
    }
}