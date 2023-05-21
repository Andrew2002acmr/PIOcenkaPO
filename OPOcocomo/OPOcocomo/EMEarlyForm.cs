using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPOcocomo
{
    public partial class EMEarlyForm : Form
    {
        public static Dictionary<string, List<double>> emCoef = new Dictionary<string, List<double>>()
        {
            { "PERS",  new List<double>(){ 2.12, 1.62, 1.26, 1, 0.83, 0.63, 0.5 } },
            { "PREX", new List<double>(){ 1.59, 1.33, 1.22, 1, 0.87, 0.74, 0.62 } },
            { "RCPX",  new List<double>(){ 0.49, 0.6, 0.83, 1, 1.33, 1.91, 2.72 } },
            { "RUSE", new List<double>(){ -1, -1, 0.95, 1, 1.07, 1.15, 1.24 } },
            { "PDIF", new List<double>(){ -1, -1, 0.87, 1, 1.29, 1.81, 2.61} },
            { "FCIL", new List<double>(){ 1.43, 1.3, 1.1, 1, 0.87, 0.73, 0.62} },
            { "SCED", new List<double>(){ -1, 1.43, 1.14, 1, 1, -1, -1} },

        };

        public static Dictionary<string, double> em = new Dictionary<string, double>()
        {
            {"PERS", 1 },
            {"PREX", 1 },
            {"RCPX", 1 },
            {"RUSE", 1 },
            {"PDIF", 1 },
            {"FCIL", 1 },
            {"SCED", 1 },
        };


        public EMEarlyForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 7;

            dataGridView1[0, 0].Value = "PERS";
            dataGridView1[0, 1].Value = "PREX";
            dataGridView1[0, 2].Value = "RCPX";
            dataGridView1[0, 3].Value = "RUSE";
            dataGridView1[0, 4].Value = "PDIF";
            dataGridView1[0, 5].Value = "FCIL";
            dataGridView1[0, 6].Value = "SCED";

            var keys = emCoef.Keys;
            int j = 0;
            foreach (var key in keys)
            {
                for (int i = 0; i < emCoef[key].Count; i++)
                {
                    if(emCoef[key][i] != -1)
                    {
                        dataGridView1[i + 1, j].Value = emCoef[key][i];

                    }

                }
                j++;

            }

        }

        private void setRate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(dataGridView1[PERSCB.SelectedIndex + 1, 0].Value) == "")
                {
                    MessageBox.Show("Множитель PERS  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[PREXCB.SelectedIndex + 1, 1].Value) == "")
                {
                    MessageBox.Show("Множитель PREX  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[RCPXCB.SelectedIndex + 1, 2].Value) == "")
                {
                    MessageBox.Show("Множитель RCPX  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[RUSECB.SelectedIndex + 1, 3].Value) == "")
                {
                    MessageBox.Show("Множитель RUSE  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[PDIFCB.SelectedIndex + 1, 4].Value) == "")
                {
                    MessageBox.Show("Множитель PDIF  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[FCILCB.SelectedIndex + 1, 5].Value) == "")
                {
                    MessageBox.Show("Множитель FCIL  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[SCEDCB.SelectedIndex + 1, 6].Value) == "")
                {
                    MessageBox.Show("Множитель SCED  не считается для этого рейтинга");
                }
                else
                {
                    em["PERS"] = Convert.ToDouble(dataGridView1[PERSCB.SelectedIndex + 1, 0].Value);
                    em["PREX"] = Convert.ToDouble(dataGridView1[PREXCB.SelectedIndex + 1, 1].Value);
                    em["RCPX"] = Convert.ToDouble(dataGridView1[RCPXCB.SelectedIndex + 1, 2].Value);
                    em["RUSE"] = Convert.ToDouble(dataGridView1[RUSECB.SelectedIndex + 1, 3].Value);
                    em["PDIF"] = Convert.ToDouble(dataGridView1[PDIFCB.SelectedIndex + 1, 4].Value);
                    em["FCIL"] = Convert.ToDouble(dataGridView1[FCILCB.SelectedIndex + 1, 5].Value);
                    em["SCED"] = Convert.ToDouble(dataGridView1[SCEDCB.SelectedIndex + 1, 6].Value);
                }

            }
            catch(Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
