using System.Runtime.InteropServices;

namespace task1
{
    class MessageBox
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBoxA(IntPtr hWnd, string text, string caption, MessageBoxButtons options, MessageBoxIcon icon);

        public static void Show(IntPtr hWnd, string text, string caption, MessageBoxButtons options, MessageBoxIcon icon)
        {
            MessageBoxA(hWnd, text, caption, options, icon);
        }
    }


    class MessageBoxInfo : MessageBox
    {

        public static void ShowInfo(string surname, string name, string patronymic)
        {
            Show(IntPtr.Zero, $"Прізвище: {surname}", "Інформація про мене [1]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Show(IntPtr.Zero, $"Ім'я: {name}", "Інформація про мене [2]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Show(IntPtr.Zero, $"По батькові: {patronymic}", "Інформація про мене [3]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
