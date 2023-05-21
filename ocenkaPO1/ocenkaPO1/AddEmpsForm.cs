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
    public partial class AddEmpsForm : Form
    {
        DataGridView empDGV;
        DataGridView startDGV;
        DataGridView endDGV;

        public AddEmpsForm(DataGridView empDGV, DataGridView startDGV, DataGridView endDGV)
        {
            InitializeComponent();

            dataGridView1.RowCount = Form1.emps.Count + 1;

            for (int i = 0; i < Form1.emps.Count; i++)
            {
                dataGridView1[0, i].Value = Form1.emps[i];
            }

            this.empDGV = empDGV;
            this.startDGV = startDGV;
            this.endDGV = endDGV;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<string> empsList = new List<string>();

            for (int i=0; i<dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridView1[0, i].Value) != "")
                {
                    empsList.Add(Convert.ToString(dataGridView1[0, i].Value));
                }
            }

            Form1.emps = empsList;

            empDGV.ColumnCount = 0;
            startDGV.ColumnCount = 0;
            endDGV.ColumnCount = 0;

            for (int i = 0; i < Form1.emps.Count; i++)
            {
                empDGV.Columns.Add("emp" + i, Form1.emps[i]);
                startDGV.Columns.Add("empStart" + i, Form1.emps[i]);
                endDGV.Columns.Add("empEnd" + i, Form1.emps[i]);
                Console.WriteLine(i);
            }


            Close();
        }
    }
}
