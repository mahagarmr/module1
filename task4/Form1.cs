using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }
    }
}