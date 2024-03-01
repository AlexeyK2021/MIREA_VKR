namespace opcUaWebMVC;

public static class Locale
{
    public static List<Language> Languages = new List<Language>()
    {
        new Russian(),
        new English(),
    };

    public static Language Language = Languages[0];
}