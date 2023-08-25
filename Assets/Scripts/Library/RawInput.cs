using System;
using System.Linq;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;

public static class RawInput
{
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int keyCode);

    public static bool KeyDown(RawKeyCode keyCode)
    {
#if UNITY_EDITOR
        return keyCode switch
        {
            RawKeyCode.Escape => UnityEngine.Input.GetKey(UnityEngine.KeyCode.Escape),
            RawKeyCode.Space => UnityEngine.Input.GetKey(UnityEngine.KeyCode.Space),
            _ => false,
        };
#else
        return (GetAsyncKeyState((int)keyCode) & 0x8000) != 0;
#endif
    }

    public static async UniTask<RawKeyCode> ReadKey()
    {
        var keyCode = RawKeyCode.None;

        await UniTask.WaitWhile(() =>
        {
            keyCode = Enum.GetValues(typeof(RawKeyCode)).Cast<RawKeyCode>().FirstOrDefault(KeyDown);
            return keyCode == RawKeyCode.None;
        });

        return keyCode;
    }
}
