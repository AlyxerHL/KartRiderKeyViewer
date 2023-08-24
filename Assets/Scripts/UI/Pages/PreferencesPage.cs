using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

public class PreferencesPage : Page
{
    [SerializeField]
    private float transitionSpeed = 1000f;

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

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}
