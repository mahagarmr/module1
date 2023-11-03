using System.Runtime.InteropServices;

class Kernel32Beep
{
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool Beep(uint dwFreq, uint dwDuration);
}

class User32MessageBeep
{
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool MessageBeep(uint uType);
}


class BeepsGenerator : Kernel32Beep 
{
    public static void GenerateBeeps(uint frequency, uint duration, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Beep(frequency, duration);
            Thread.Sleep((int)duration);
        }
    }
}

class MessageBeepsGenerator : User32MessageBeep
{
    public static void GenerateMessageBeeps(uint type, int count)
    {
        for (int i = 0; i < count; i++)
        {
            MessageBeep(type);
            Thread.Sleep(500);
        }
    }
}