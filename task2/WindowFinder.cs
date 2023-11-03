using System.Runtime.InteropServices;

public class WindowFinder
{
    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
}

public class FindWindowByTitle : WindowFinder
{
    public static IntPtr Find(string title)
    {
        return FindWindow(null, title);
    }
}