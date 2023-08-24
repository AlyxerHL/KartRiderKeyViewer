using UnityEngine;

public class KeyViewerUI : MonoBehaviour
{
    [SerializeField]
    private Key[] keys;

    private void Update()
    {
        foreach (var key in keys)
        {
            if (RawInput.KeyDown(key.KeyCode))
            {
                key.OnPressed();
            }
            else
            {
                key.OnReleased();
            }
        }
    }
}
