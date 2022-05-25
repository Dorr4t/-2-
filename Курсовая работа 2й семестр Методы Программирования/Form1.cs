using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using NUnit.Framework;


namespace Курсовая_работа_2й_семестр_Методы_Программирования
{
    public class Worker
    {
        public string LastName;
        public int Qualification;
        public int WorkshopNumber;
        public string Date;
        public double CostOfOneHour;
        public double AmountOfTimeWorked;
    }

    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 AddNewData = new Form2();
            AddNewData.Show(this);  
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void выключитьРежимРедаактированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void удалитьЗаписьОРабочемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiddleOfTime(dataGridView1);
        }
        public void MiddleOfTime(DataGridView DGV)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DateTime date1 = DateTime.Parse((string)DGV[3, i].Value);
                DateTime date2 = DateTime.Now;
                int days = (date2 - date1).Days;
                if (days == 0)
                {
                    DGV[6, i].Value = 0;
                }
                else
                {
                    double WorkerHoursPerDay = Int32.Parse(DGV[5, i].Value.ToString()) / days;
                    DGV[6, i].Value = WorkerHoursPerDay;
                }
            }

           
        }

        private void максимальнуюСтоимостьОдногоЧасаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 MaxCostOneHour = new Form3();
            MaxCostOneHour.Show(this);
        }

        private void количествоОтработанныхЧасовПоФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show(this);
        }

        private void создатьТаблицуФамилияРаботникаСуммарнаяСтоимостьОтработанногоВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show(this);
        }

        private void изменитьСтоимостьОдногоЧасаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show(this);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {

                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWritet.Write(dataGridView1.Rows[i].Cells[j].Value + "ᅠ");
                            }
                            myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void открытьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num - 1;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('ᅠ');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch { }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }

        private void удалитьСведенияОРаботникахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiddleofMiddleOfTime(dataGridView1);

        }

        public void MiddleofMiddleOfTime(DataGridView DGV)
        {
            MiddleOfTime(DGV);
            double middleTimeOfDay = 0;
            for (int i = 0; i < DGV.RowCount; i++)
            {
                middleTimeOfDay = middleTimeOfDay + (double) DGV[6, i].Value;
            }
            middleTimeOfDay = middleTimeOfDay / DGV.RowCount;
            for (int i = dataGridView1.RowCount-1; i >= 0;i--)
            {
                if ((double)DGV[6,i].Value < middleTimeOfDay)
                {
                    DGV.Rows.RemoveAt(i);
                }
            }
        }
    }



}
