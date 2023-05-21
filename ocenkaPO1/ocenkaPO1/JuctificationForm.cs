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
    public partial class JuctificationForm : Form
    {
        public JuctificationForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 5;

            dataGridView1[0, 0].Value = "Затраты на разработку и внедрение проекта, руб.";
            dataGridView1[0, 1].Value = "Общие эксплуатационные затраты, руб. ";
            dataGridView1[0, 2].Value = "Экономический эффект, руб.";
            dataGridView1[0, 3].Value = "Коэффициент экономической эффективности";
            dataGridView1[0, 4].Value = "Срок окупаемости, лет";

            try
            {
                dataGridView1[1, 0].Value = Form1.costs;
                dataGridView1[1, 1].Value = Form1.yearCost;
                dataGridView1[1, 2].Value = Form1.e;
                dataGridView1[1, 3].Value = Form1.ef;
                dataGridView1[1, 4].Value = Form1.term;
            }
            catch(Exception excp)
            {
                MessageBox.Show("Ошибка:\n\n" + excp.Message);
            }
        }
    }
}
