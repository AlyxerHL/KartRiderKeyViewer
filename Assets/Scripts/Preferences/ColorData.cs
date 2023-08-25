using UnityEngine;

public class ColorData
{
    private static readonly Color accentColor = new(0.2588235294f, 0.5215686275f, 0.9568627451f);

    public Color key { get; set; } = Color.black;
    public Color keyPressed { get; set; } = accentColor;
    public Color outline { get; set; } = accentColor;
    public Color outlinePressed { get; set; } = accentColor;
    public Color symbol { get; set; } = accentColor;
    public Color symbolPressed { get; set; } = Color.black;
    public Color background { get; set; } = Color.black;
}
