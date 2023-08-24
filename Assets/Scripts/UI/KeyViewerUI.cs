using UnityEngine;

public class KeyViewerUI : MonoBehaviour
{
    [SerializeField]
    private Key[] keys;

    public void OpenPreferences()
    {
        Debug.Log("Open Preferences");
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
}
