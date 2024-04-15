using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba4
{
    public partial class Task_2 : Form
    {
        public List<aeroflot> fly = new List<aeroflot>(10);
        public string[] name = { "Амстердам", "Токио", "Лондон", "Москва", "Берлин" };
        public List<string> typ = new List<string> { "Boeing 777", "Boeing 737", "Airbus a380" };
        public Task_2()
        {
            InitializeComponent();
        }
        private void Task_2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string path = "airplanes.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLineAsync($"{typ[rnd.Next(0, 3)]}");
                    writer.WriteLineAsync($"{name[rnd.Next(0, name.Length)]}");
                    writer.WriteLineAsync($"{rnd.Next(0, 300)}");
                }
            }
            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 0; i < 31; i++)
                    fly.Add(new aeroflot(reader.ReadLine(), reader.ReadLine(), Convert.ToInt32(reader.ReadLine())));
            }
            foreach (string tp in typ)
                listBox1.Items.Add(tp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add("Ничего не выбрано");
                }
                else
                {
                    string text = textBox1.Text;
                    if (typ.Contains(text))
                    {
                        listBox2.Items.Clear();
                        foreach (aeroflot tp in fly.OrderBy(w => w.place))
                            if (text == tp.type)
                                listBox2.Items.Add($"Пункт назначения: {tp.place} Номер рейса: {tp.number}");
                    }
                    else
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add("Такого рейса нет");
                    }
                }
            }
            catch (FormatException)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Не верный формат");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class aeroflot
    {
        public string place { get; set; }
        public int number { get; set; }
        public string type { get; set; }
        public aeroflot()
        {

        }
        public aeroflot(string type1, string place1, int number1)
        {
            this.place = place1;
            this.number = number1;
            this.type = type1;
        }
    }
}
