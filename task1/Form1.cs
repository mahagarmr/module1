// Успадкування MessageBox знаходиться в файлі MessageBox.cs !!

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string surname = "Ерназаров";
            string name = "Артем";
            string patronymic = "Русланович";
            MessageBoxInfo.ShowInfo(surname, name, patronymic);
        }
    }
}