using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPOcocomo
{
    public partial class BasicCocomoForm : Form
    {
        public BasicCocomoForm()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;


            dataGridView1[0, 0].Value = "Распространенный";
            dataGridView1[0, 1].Value = "Полунезависимый";
            dataGridView1[0, 2].Value = "Встроенный";

            dataGridView1[1, 0].Value = 2.4;
            dataGridView1[1, 1].Value = 3;
            dataGridView1[1, 2].Value = 3.6;

            dataGridView1[2, 0].Value = 1.05;
            dataGridView1[2, 1].Value = 1.12;
            dataGridView1[2, 2].Value = 1.2;

            dataGridView1[3, 0].Value = 2.5;
            dataGridView1[3, 1].Value = 2.5;
            dataGridView1[3, 2].Value = 2.5;

            dataGridView1[4, 0].Value = 0.38;
            dataGridView1[4, 1].Value = 0.35;
            dataGridView1[4, 2].Value = 0.32;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(textBox1.Text);
                int id = comboBox1.SelectedIndex;
                double pm = Convert.ToDouble(dataGridView1[1, comboBox1.SelectedIndex].Value) * Math.Pow(size, Convert.ToDouble(dataGridView1[2, comboBox1.SelectedIndex].Value));
                double tm = Convert.ToDouble(dataGridView1[3, comboBox1.SelectedIndex].Value) * Math.Pow(pm, Convert.ToDouble(dataGridView1[4, comboBox1.SelectedIndex].Value));

                dataGridView2.RowCount = 1;
                dataGridView2[0, 0].Value = pm;
                dataGridView2[1, 0].Value = tm;


            }
            catch(Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
