using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocenkaPO1
{
    public partial class YearCostsForm : Form
    {
        public YearCostsForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 6;

            dataGridView1[0, 0].Value = "Основная и дополнительная зарплата с отчислениями во";
            dataGridView1[0, 1].Value = "Амортизационные отчисления ";
            dataGridView1[0, 2].Value = "Затраты на электроэнергию ";
            dataGridView1[0, 3].Value = "Затраты на текущий ремонт ";
            dataGridView1[0, 4].Value = "Затраты на материалы";
            dataGridView1[0, 5].Value = "Накладные расходы";

            dataGridView1[1, 0].Value = 69440.00;
            dataGridView1[1, 1].Value = 1093.12;
            dataGridView1[1, 2].Value = 499.2;
            dataGridView1[1, 3].Value = 273.28;
            dataGridView1[1, 4].Value = 255;
            dataGridView1[1, 5].Value = 14306.12;

            dataGridView1[2, 0].Value = 112840.00;
            dataGridView1[2, 1].Value = 1821.86;
            dataGridView1[2, 2].Value = 832;
            dataGridView1[2, 3].Value = 455.47;
            dataGridView1[2, 4].Value = 225;
            dataGridView1[2, 5].Value = 23234.87;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double proj = 0;
                double analog = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    proj += Convert.ToDouble(dataGridView1[1, i].Value);
                    analog += Convert.ToDouble(dataGridView1[2, i].Value);
                }

                dataGridView2.RowCount = 1;
                dataGridView2[0, 0].Value = proj;
                dataGridView2[1, 0].Value = analog;

                Form1.yearCost = proj;

            }
            catch (Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
