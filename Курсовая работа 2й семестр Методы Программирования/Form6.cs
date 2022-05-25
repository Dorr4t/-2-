using System;
using System.Windows.Forms;

namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Num1 = Double.Parse(textBox1.Text);
            double Num2 = Double.Parse(textBox2.Text)/100;
            for (int i = 0; i < ((Form1)Owner).dataGridView1.RowCount; i++)
            {
                if (Num1 == Double.Parse(((Form1)Owner).dataGridView1[2, i].Value.ToString()))
                {
                    ((Form1)Owner).dataGridView1[4, i].Value = Double.Parse(((Form1)Owner).dataGridView1[4, i].Value.ToString()) * Num2;
                }
            }
        }
    }
}
