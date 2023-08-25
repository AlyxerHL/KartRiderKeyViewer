using Cysharp.Threading.Tasks;
using UnityEngine;

public class KeyViewerPage : Page
{
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

    private void Start()
    {
        foreach (var key in keys)
        {
            key.keyCode = Preferences.LoadKey(key.name, key.keyCode);
        }
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
}
