using System;
using System.Windows.Forms;

namespace laba4
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double n = trackBar1.Value;
            double s = 0;
            label1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
            if (checkBox1.Checked == true & checkBox2.Checked == true)
            {
                label2.Text = ($"Выбери что-то одно!");
            }
            else if (checkBox2.Checked == true)
            {
                for (int i = 1; i <= n; i++)
                {
                    s += Math.Pow(i,2);
                }
                label2.Text = ($"{s}");
            }
            else if (checkBox1.Checked == true)
            {
                label2.Text = ($"{n * (n + 1) * (2 * n + 1) / 6}");
            }
            else
            {
                label2.Text = ($"Ничего не выбрано!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
