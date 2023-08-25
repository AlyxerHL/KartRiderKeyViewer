using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
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
    private Color outlinePressedColor = Color.white;

    [SerializeField]
    private Color outlineReleasedColor = Color.white;

    [SerializeField]
    private Color backgroundPressedColor = Color.white;

    [SerializeField]
    private Color backgroundReleasedColor = Color.black;

    [SerializeField]
    private Color symbolPressedColor = Color.black;

    [SerializeField]
    private Color symbolReleasedColor = Color.white;

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
