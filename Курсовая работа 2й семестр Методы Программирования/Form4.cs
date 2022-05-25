using System;
using System.Windows.Forms;

namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker Date1 = dateTimePicker1;
            Date1.Format = DateTimePickerFormat.Custom;
            Date1.CustomFormat = "MMMM dd, yyyy";
            for (int i = 0; i < ((Form1)Owner).dataGridView1.RowCount; i++)
            {
                string textB1 = textBox1.Text;
                dynamic textG1 = ((Form1)Owner).dataGridView1[0, i].Value;
                string date1 = Date1.Value.ToShortDateString();
                dynamic date2 = ((Form1)Owner).dataGridView1[3, i].Value;
                if(textB1 == textG1 && date1 == date2)
                {
                    label3.Text = "Количество отработаных часов: " + ((Form1)Owner).dataGridView1[5, i].Value.ToString();
                }
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }
    }
}
