using System;
using System.Windows.Forms;


namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            int min = 0;
            int IndexCellMaxCostOneHour = 0;
            for (int i = 0; i < ((Form1)Owner).dataGridView1.RowCount; i++)
            {
                int temps = Convert.ToInt32(((Form1)Owner).dataGridView1[4, i].Value);
                if (temps > min)
                {   
                    min = Int32.Parse(((Form1)Owner).dataGridView1[4, i].Value.ToString());
                    IndexCellMaxCostOneHour = i;
                }
            }
            label8.Text = ((Form1)Owner).dataGridView1[0, IndexCellMaxCostOneHour].Value.ToString();
            label9.Text = ((Form1)Owner).dataGridView1[1, IndexCellMaxCostOneHour].Value.ToString();
            label10.Text = ((Form1)Owner).dataGridView1[2, IndexCellMaxCostOneHour].Value.ToString();
            label11.Text = ((Form1)Owner).dataGridView1[3, IndexCellMaxCostOneHour].Value.ToString();
            label12.Text = ((Form1)Owner).dataGridView1[5, IndexCellMaxCostOneHour].Value.ToString();
            label13.Text = ((Form1)Owner).dataGridView1[4, IndexCellMaxCostOneHour].Value.ToString();
        }
    }
}
