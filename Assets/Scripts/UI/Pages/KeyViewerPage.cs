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

    private void OnEnable()
    {
        LoadPreferences();
    }

    private void Update()
    {
        foreach (var key in keys)
        {
            if (RawInput.KeyDown(key.keyCode))
            {
                key.Press();
            }
            else
            {
                key.Release();
            }
        }
    }

    private void LoadPreferences()
    {
        background.color = Preferences.LoadColor(background.name, background.color);
        foreach (var key in keys)
        {
            key.keyCode = Preferences.LoadKey(key.name, key.keyCode);
            key.keyColor = Preferences.LoadColor("Key", key.keyColor);
            key.keyPressColor = Preferences.LoadColor("KeyPress", key.keyPressColor);
            key.borderColor = Preferences.LoadColor("Border", key.borderColor);
            key.borderPressColor = Preferences.LoadColor("BorderPress", key.borderPressColor);
            key.textColor = Preferences.LoadColor("Text", key.textColor);
            key.textPressColor = Preferences.LoadColor("TextPress", key.textPressColor);
        }
    }
}
