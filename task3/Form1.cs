// Успадкування Beep та MessageBeep знаходиться в файлі SoundGenerator.cs !!

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beepButton_Click(object sender, EventArgs e)
        {
            uint frequency = uint.Parse(frequencyTextBox.Text);
            uint duration = uint.Parse(durationTextBox.Text);
            BeepsGenerator.GenerateBeeps(frequency, duration, 3);
        }

        private void messageBeepButton_Click(object sender, EventArgs e)
        {
            uint type = 0xFFFFFFFF;
            MessageBeepsGenerator.GenerateMessageBeeps(type, 3);
        }
    }
}