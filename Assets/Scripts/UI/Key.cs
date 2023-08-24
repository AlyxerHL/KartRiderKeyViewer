using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    private static readonly Color accent = new Color(0.2588235294f, 0.5215686275f, 0.9568627451f);
    private static readonly Colors outlineColors = new(accent, accent);
    private static readonly Colors backgroundColors = new(accent, Color.black);
    private static readonly Colors symbolColors = new(Color.black, accent);

    [SerializeField]
    private Graphic outline;

    [SerializeField]
    private Graphic background;

    [SerializeField]
    private Graphic symbol;

    [SerializeField]
    private RawKeyCode keyCode;

    public RawKeyCode KeyCode => keyCode;

    public void OnPressed()
    {
        outline.color = outlineColors.pressed;
        background.color = backgroundColors.pressed;
        symbol.color = symbolColors.pressed;
    }

    public void OnReleased()
    {
        outline.color = outlineColors.released;
        background.color = backgroundColors.released;
        symbol.color = symbolColors.released;
    }

    private struct Colors
    {
        public Color pressed { get; set; }
        public Color released { get; set; }

        public Colors(Color pressed, Color released)
        {
            this.pressed = pressed;
            this.released = released;
        }
    }
}
