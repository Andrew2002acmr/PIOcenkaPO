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
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = Form1.emps.Count;

            for(int i = 0; i < Form1.emps.Count; i++)
            {
                dataGridView1[0, i].Value = Form1.emps[i];
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double amount = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                double w = Convert.ToDouble(dataGridView1[3, i].Value) / 21;
                double ozp = Math.Round(Convert.ToDouble(dataGridView1[1, i].Value) * w, 2);
                amount += ozp;
                dataGridView1[4, i].Value = ozp;
            }

            label1.Text = "Итого: " + amount;
        }
    }
}
