using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class KeyInput : MonoBehaviour
{
    [Header("Targets")]
    [SerializeField]
    private TextMeshProUGUI preview;

    [SerializeField]
    private TextMeshProUGUI placeholder;

    [Header("Properties")]
    [SerializeField]
    private RawKeyCode keyCode;

    [SerializeField]
    private UnityEvent<RawKeyCode> onKeyCodeChanged;

    public void HandleClick()
    {
        async UniTask HandleClickAsync()
        {
            placeholder.gameObject.SetActive(true);
            preview.gameObject.SetActive(false);

            var newKeyCode = await RawInput.ReadKey();
            if (newKeyCode != RawKeyCode.Escape)
            {
                keyCode = newKeyCode;
                onKeyCodeChanged.Invoke(keyCode);
                preview.text = keyCode.ToString();
            }

            placeholder.gameObject.SetActive(false);
            preview.gameObject.SetActive(true);
        }

        HandleClickAsync().Forget();
    }

    private void Awake()
    {
        preview.text = keyCode.ToString();
    }
}
