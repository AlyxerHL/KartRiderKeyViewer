using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PreferencesPage : Page
{
    private static readonly Color accentColor = new(0.5411764706f, 0.7058823529f, 0.9725490196f);

    [SerializeField]
    private float transitionSpeed = 1000f;

    [SerializeField]
    private Image colorSymbol;

    [SerializeField]
    private GameObject colorTab;

    [SerializeField]
    private Image keySymbol;

    [SerializeField]
    private GameObject keyTab;

    private RectTransform rectTransform;

    public override async UniTask Show()
    {
        gameObject.SetActive(true);
        rectTransform.anchoredPosition = new Vector2(Screen.width, 0);

        await rectTransform
            .DOAnchorPosX(0, transitionSpeed)
            .SetEase(Ease.OutExpo)
            .SetSpeedBased()
            .AsyncWaitForCompletion();
    }

    public override async UniTask Hide()
    {
        rectTransform.anchoredPosition = Vector2.zero;

        await rectTransform
            .DOAnchorPosX(Screen.width, transitionSpeed)
            .SetEase(Ease.OutExpo)
            .SetSpeedBased()
            .AsyncWaitForCompletion();
        gameObject.SetActive(false);
    }

    public void Close()
    {
        Navigator.Pop().Forget();
    }

    public void OpenColorTab()
    {
        colorTab.SetActive(true);
        keyTab.SetActive(false);
        colorSymbol.color = accentColor;
        keySymbol.color = Color.white;
    }

    public void OpenKeyTab()
    {
        colorTab.SetActive(false);
        keyTab.SetActive(true);
        colorSymbol.color = Color.white;
        keySymbol.color = accentColor;
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}
