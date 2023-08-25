public static class Preferences
{
    public static KeyData key { get; } = ES3.Load(nameof(KeyData), new KeyData());
    public static ColorData color { get; } = ES3.Load(nameof(ColorData), new ColorData());

    public static void Save()
    {
        ES3.Save(nameof(KeyData), key);
        ES3.Save(nameof(ColorData), color);
    }
}
