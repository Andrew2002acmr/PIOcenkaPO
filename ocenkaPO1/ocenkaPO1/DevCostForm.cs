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
    public partial class DevCostForm : Form
    {
        public DevCostForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 6;

            dataGridView1[0, 0].Value = "Основная заработная плата ";
            dataGridView1[0, 1].Value = "Дополнительная зарплата";
            dataGridView1[0, 2].Value = "Отчисления на социальные нужды ";
            dataGridView1[0, 3].Value = "Затраты на материалы";
            dataGridView1[0, 4].Value = "Затраты на машинное время";
            dataGridView1[0, 5].Value = "Накладные расходы организации";

            dataGridView1[1, 0].Value = 55523.81;
            dataGridView1[1, 1].Value = 22209.52;
            dataGridView1[1, 2].Value = 23475.47;
            dataGridView1[1, 3].Value = 1200;
            dataGridView1[1, 4].Value = 9200;
            dataGridView1[1, 5].Value = 33314.29;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToString(dataGridView1[1, i].Value) != "")
                    {

                        amount += Convert.ToDouble(dataGridView1[1, i].Value);
                    }
                    else
                    {
                        MessageBox.Show("Затраты должны быть числами");
                    }
                }

                double comp = 22500;

                double kr = (comp * 1 * 6 * 247)/ (247 * 8);

                Form1.costs = kr + amount;

                label1.Text = "Итого: " + amount;
            }
            catch (Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
