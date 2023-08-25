using UnityEngine;

public static class Preferences
{
    private static readonly ES3File preferences = new("preferences.es3");

    public static void Sync()
    {
        preferences.Sync();
    }

    public static RawKeyCode LoadKey(string id, RawKeyCode defaultValue)
    {
        return preferences.Load($"key_{id}", defaultValue);
    }

    public static void SaveKey(string id, RawKeyCode value)
    {
        preferences.Save($"key_{id}", value);
    }

    public static Color LoadColor(string id, Color defaultValue)
    {
        return preferences.Load($"color_{id}", defaultValue);
    }

    public static void SaveColor(string id, Color value)
    {
        preferences.Save($"color_{id}", value);
    }
}
