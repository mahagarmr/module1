// Успадкування WindowFinder знаходиться в файлі WindowFinder.cs !!

using System.Runtime.InteropServices;

namespace task2
{
    public partial class Form1 : Form
    {
        private IntPtr windowHandle;

        private const int WM_SETTEXT = 0x000C;
        private const int WM_CLOSE = 0x0010;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

        public Form1()
        {
            InitializeComponent();
            windowHandle = FindWindowByTitle.Find("Spotify Free");
        }

        private void changeTitleButton_Click(object sender, EventArgs e)
        {
            string newTitle = newTitleTextBox.Text;
            SendMessage(windowHandle, WM_SETTEXT, IntPtr.Zero, newTitle);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            SendMessage(windowHandle, WM_CLOSE, IntPtr.Zero, "");
        }
    }
}