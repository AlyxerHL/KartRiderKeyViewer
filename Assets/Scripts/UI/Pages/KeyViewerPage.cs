using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class KeyViewerPage : Page
{
    [SerializeField]
    private Image background;

    [SerializeField]
    private Key[] keys;

    public override UniTask Show()
    {
        gameObject.SetActive(true);
        return UniTask.CompletedTask;
    }

    public override UniTask Hide()
    {
        gameObject.SetActive(false);
        return UniTask.CompletedTask;
    }

    public void OpenPreferences()
    {
        Navigator.Push("PreferencesPage").Forget();
    }

    private void Update()
    {
        foreach (var key in keys)
        {
            if (RawInput.KeyDown(key.KeyCode))
            {
                key.Press();
            }
            else
            {
                key.Release();
            }
        }
    }

    private void OnEnable()
    {
        background.color = Preferences.LoadColor(background.name, background.color);
        foreach (var key in keys)
        {
            key.KeyCode = Preferences.LoadKey(key.name, key.KeyCode);
            key.KeyColor = Preferences.LoadColor("Key", key.KeyColor);
            key.KeyPressColor = Preferences.LoadColor("KeyPress", key.KeyPressColor);
            key.BorderColor = Preferences.LoadColor("Border", key.BorderColor);
            key.BorderPressColor = Preferences.LoadColor("BorderPress", key.BorderPressColor);
            key.TextColor = Preferences.LoadColor("Text", key.TextColor);
            key.TextPressColor = Preferences.LoadColor("TextPress", key.TextPressColor);
        }
    }
}
