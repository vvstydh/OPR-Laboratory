using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double v = double.Parse(V.Text);
                double s = double.Parse(S.Text);
                answer.Text = ($"Так вот какова высота цилиндра:\n {v / s}");
            }
            catch (FormatException) { answer.Text = ($"Прости, не верный формат"); }
        }
    }
}
