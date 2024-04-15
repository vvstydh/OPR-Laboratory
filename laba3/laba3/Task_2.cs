using System;
using System.Windows.Forms;

namespace laba3
{
    public partial class Task_2 : Form
    {
        public Task_2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = 0;
                if (checkBox1.Checked == true & checkBox2.Checked == true)
                {
                    label1.Text = ($"Выбери что-то одно!");
                }
                else if (checkBox2.Checked == true)
                {
                    c = Math.Sqrt(a * b);
                    label1.Text = ($"{c}");
                }
                else if (checkBox1.Checked == true)
                {
                    c = (a + b) / 2;
                    label1.Text = ($"{c}");
                }
                else
                {
                    label1.Text = ($"Ничего не выбрано!");
                }
            }
            catch (FormatException) { label1.Text = ("Не верный формат!"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
