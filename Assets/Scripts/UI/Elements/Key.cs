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
    public RawKeyCode KeyCode { get; set; } = RawKeyCode.None;

    [field: SerializeField]
    public Color KeyColor { get; set; } = Color.black;

    [field: SerializeField]
    public Color KeyPressColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color BorderColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color BorderPressColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color TextColor { get; set; } = Color.white;

    [field: SerializeField]
    public Color TextPressColor { get; set; } = Color.black;

    public void Press()
    {
        key.color = KeyPressColor;
        border.color = BorderPressColor;
        text.color = TextPressColor;
    }

    public void Release()
    {
        key.color = KeyColor;
        border.color = BorderColor;
        text.color = TextColor;
    }
}
