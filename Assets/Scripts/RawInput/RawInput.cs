using System.Runtime.InteropServices;

public static class RawInput
{
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int keyCode);

    public static bool KeyDown(RawKeyCode keyCode)
    {
#if UNITY_EDITOR
        return UnityEngine.Input.GetKey(UnityEngine.KeyCode.Space);
#else
        return (GetAsyncKeyState((int)keyCode) & 0x8000) != 0;
#endif
    }
}
