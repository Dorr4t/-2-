using System;
using System.Windows.Forms;

namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            int ind = ((Form1)Owner).dataGridView1.SelectedCells[0].ColumnIndex;
            int id = Int32.Parse((((Form1)Owner).dataGridView1[2, ind].Value).ToString());
            for (int i = 0; i < ((Form1)Owner).dataGridView1.RowCount; i++)
            {
                int id1 = Int32.Parse((((Form1)Owner).dataGridView1[2, i].Value).ToString());
                if (id1 == id)
                {
                    dynamic AllCost = Double.Parse(((Form1)Owner).dataGridView1[4, i].Value.ToString()) * Double.Parse(((Form1)Owner).dataGridView1[5, i].Value.ToString());
                    dataGridView2.Rows.Add(((Form1)Owner).dataGridView1[0, i].Value, AllCost);
                }
               
            }
        }
    }
}
