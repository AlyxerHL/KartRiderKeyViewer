using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [Header("Targets")]
    [SerializeField]
    private Image key;

    [SerializeField]
    private Image border;

    [SerializeField]
    private Graphic text;

    [field: Header("Properties")]
    [field: SerializeField]
    public RawKeyCode keyCode { get; set; } = RawKeyCode.None;

    [field: SerializeField]
    public Color keyColor { get; set; } = Color.black;

    [field: SerializeField]
    public Color keyPressColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color borderColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color borderPressColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color textColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color textPressColor { get; set; } = Color.black;

    public void Press()
    {
        key.color = keyPressColor;
        border.color = borderPressColor;
        text.color = textPressColor;
    }

    public void Release()
    {
        key.color = keyColor;
        border.color = borderColor;
        text.color = textColor;
    }
}
