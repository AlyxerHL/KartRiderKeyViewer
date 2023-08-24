using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    private static readonly Color accent = new Color(0.2588235294f, 0.5215686275f, 0.9568627451f);

    [Header("Targets")]
    [SerializeField]
    private Image outline;

    [SerializeField]
    private Image background;

    [SerializeField]
    private TextMeshProUGUI symbolText;

    [SerializeField]
    private Image symbolImage;

    [Header("Colors")]
    [SerializeField]
    private Color outlinePressedColor = accent;

    [SerializeField]
    private Color outlineReleasedColor = accent;

    [SerializeField]
    private Color backgroundPressedColor = accent;

    [SerializeField]
    private Color backgroundReleasedColor = Color.black;

    [SerializeField]
    private Color symbolPressedColor = Color.black;

    [SerializeField]
    private Color symbolReleasedColor = accent;

    [Header("Properties")]
    [SerializeField]
    private SymbolType symbolType = SymbolType.Text;

    [SerializeField]
    private string symbolTextValue = "X";

    [SerializeField]
    private Sprite symbolImageValue = null;

    [SerializeField]
    private Vector2 symbolImageOffset = Vector2.zero;

    [SerializeField]
    private Vector2 symbolImageSize = Vector2.one * 65f;

    [SerializeField]
    private Vector3 symbolImageRotation = Vector3.zero;

    [SerializeField]
    private RawKeyCode keyCode = RawKeyCode.None;

    public RawKeyCode KeyCode => keyCode;

    public void Press()
    {
        outline.color = outlinePressedColor;
        background.color = backgroundPressedColor;
        symbolText.color = symbolPressedColor;
        symbolImage.color = symbolPressedColor;
    }

    public void Release()
    {
        outline.color = outlineReleasedColor;
        background.color = backgroundReleasedColor;
        symbolText.color = symbolReleasedColor;
        symbolImage.color = symbolReleasedColor;
    }

    private void Awake()
    {
        if (symbolType == SymbolType.Text)
        {
            symbolText.text = symbolTextValue;
            symbolText.gameObject.SetActive(true);
        }
        else if (symbolType == SymbolType.Image)
        {
            symbolImage.sprite = symbolImageValue;
            symbolImage.rectTransform.anchoredPosition = symbolImageOffset;
            symbolImage.rectTransform.sizeDelta = symbolImageSize;
            symbolImage.rectTransform.localEulerAngles = symbolImageRotation;
            symbolImage.gameObject.SetActive(true);
        }
    }

    public enum SymbolType
    {
        Text,
        Image
    }
}
