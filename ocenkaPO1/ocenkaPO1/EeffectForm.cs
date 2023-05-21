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
    public partial class EeffectForm : Form
    {
        public EeffectForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 3;
            dataGridView2.RowCount = 1;

            dataGridView1[0, 0].Value = "Себестоимость (текущие эксплуатационные затраты), руб.";
            dataGridView1[0, 1].Value = "Суммарные затраты, связанные с внедрением проекта, руб.";
            dataGridView1[0, 2].Value = "Приведенные затраты на единицу работ, руб.";

            dataGridView1[1, 0].Value = 139409.19;
            dataGridView1[1, 1].Value = 80800.00;

            dataGridView1[2, 0].Value = 85836.72;
            dataGridView1[2, 1].Value = 161798.09;

            dataGridView2[0, 0].Value = "Экономический эффект от использования разрабатываемой системы, руб. ";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double eh = 0.33;
            double z1 = Convert.ToDouble(dataGridView1[1, 0].Value) + (eh * Convert.ToDouble(dataGridView1[1, 1].Value));
            double z2 = Convert.ToDouble(dataGridView1[2, 0].Value) + (eh * Convert.ToDouble(dataGridView1[2, 1].Value));

            double exp = (z1 * 1.6) - z2;

            Form1.e = exp;

            dataGridView1[1, 2].Value = z1;
            dataGridView1[2, 2].Value = z2;
            dataGridView2[1, 0].Value = exp;

            double term = Convert.ToDouble(dataGridView1[2, 1].Value) / exp;
            Form1.term = term;
            
            double ef = 1 / term;

            Form1.ef = ef;

            label1.Text = "Срок окупаемости: " + term;
            
        }
    }
}
