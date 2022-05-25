using System;
using System.Windows.Forms;

namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    public partial class Form2 : Form
    {
        public static string LastName;
        public static string Qualification;
        public static int WorkshopNumber;
        public static int CostOfOneHour;
        public static int AmountOfTimeWorked;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                LastName = textBox1.Text;
                Qualification = textBox2.Text;
                WorkshopNumber = Convert.ToInt32(textBox3.Text);
                DateTimePicker Date = dateTimePicker1;
                Date.Format = DateTimePickerFormat.Custom;
                Date.CustomFormat = "MMMM dd, yyyy";
                CostOfOneHour = Convert.ToInt32(textBox5.Text);
                AmountOfTimeWorked = Convert.ToInt32(textBox6.Text);
                ((Form1)Owner).dataGridView1.Rows.Add(LastName, Qualification, WorkshopNumber, Date.Value.ToShortDateString(), CostOfOneHour, AmountOfTimeWorked);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные");
            }
        }
    }
}
