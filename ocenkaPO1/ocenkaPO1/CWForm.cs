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
    public partial class CWForm : Form
    {

        

        public CWForm()
        {
            InitializeComponent();




            for (int i = 0; i < Form1.emps.Count; i++)
            {
                empsDGV.Columns.Add("emp" + i, Form1.emps[i]);
                dataGridView1.Columns.Add("emp" + i, Form1.emps[i]);
                dataGridView2.Columns.Add("emp" + i, Form1.emps[i]);
            }

        }

        private void AddEmps_Click(object sender, EventArgs e)
        {
            AddEmpsForm addEmpsForm = new AddEmpsForm(empsDGV, dataGridView1, dataGridView2);

            addEmpsForm.Show();
        }

        private void calculateSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = DateTime.Parse(startDateTB.Text);
                

                dataGridView1.RowCount = worksDGV.RowCount;
                dataGridView2.RowCount = worksDGV.RowCount;

                for (int i = 0; i < worksDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < empsDGV.Columns.Count; j++)
                    {
                        DateTime end = start.AddDays(Convert.ToDouble(empsDGV[j, i].Value) - 1);
                        if (Convert.ToDouble(empsDGV[j, i].Value) > 0)
                        {
                            dataGridView1[j, i].Value = start;
                            dataGridView2[j, i].Value = end;
                        }

                    }
                    start = start.AddDays(Convert.ToDouble(worksDGV[1, i].Value));
                }


            }
            catch(Exception excp)
            {
                MessageBox.Show("Что-то не так\n\n" + excp.Message);
            }
        }
    }
}
