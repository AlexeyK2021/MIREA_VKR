namespace opcUaWebMVC;

/// <summary>
/// Класс для определения языков в системе 
/// </summary>
public static class Locale
{
    public static List<Language> Languages = new List<Language>()
    {
        new Russian(),
        new English(),
    };

    /// <summary>
    /// Текущий язык пользователя
    /// </summary>
    public static Language Language = Languages[0];
}