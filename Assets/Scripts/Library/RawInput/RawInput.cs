using System.Runtime.InteropServices;
using UnityEngine;

public static class RawInput
{
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int keyCode);

    private static bool KeyDown(RawKeyCode keyCode)
    {
        return (GetAsyncKeyState((int)keyCode) & 0x8000) != 0;
    }
}
