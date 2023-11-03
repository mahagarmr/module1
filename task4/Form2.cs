using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        form1.button2.BackColor = Color.Blue;
                        form1.textBox1.BackColor = Color.Blue;
                        break;
                    }

                case 1:
                    {
                        form1.button2.BackColor = Color.Red;
                        form1.textBox1.BackColor = Color.Red;
                        break;
                    }

            }
        }
    }
}
