using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    private static readonly Color accentColor = new(0.2588235294f, 0.5215686275f, 0.9568627451f);

    [Header("Targets")]
    [SerializeField]
    private Image outline;

    [SerializeField]
    private Image background;

    [SerializeField]
    private Graphic symbol;

    [Header("Properties")]
    [SerializeField]
    private RawKeyCode keyCode = RawKeyCode.None;

    [SerializeField]
    private Color outlinePressedColor = accentColor;

    [SerializeField]
    private Color outlineReleasedColor = accentColor;

    [SerializeField]
    private Color backgroundPressedColor = accentColor;

    [SerializeField]
    private Color backgroundReleasedColor = Color.black;

    [SerializeField]
    private Color symbolPressedColor = Color.black;

    [SerializeField]
    private Color symbolReleasedColor = accentColor;

    public RawKeyCode KeyCode => keyCode;

    public void Press()
    {
        outline.color = outlinePressedColor;
        background.color = backgroundPressedColor;
        symbol.color = symbolPressedColor;
    }

    public void Release()
    {
        outline.color = outlineReleasedColor;
        background.color = backgroundReleasedColor;
        symbol.color = symbolReleasedColor;
    }
}
