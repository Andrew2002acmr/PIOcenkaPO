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
    public partial class SFForm : Form
    {
        public static Dictionary<string, List<double>> sfCoef = new Dictionary<string, List<double>>()
        {
            { "PREC",  new List<double>(){ 6.2, 4.96, 3.72, 2.48, 1.24, 0 } },
            { "FLEX", new List<double>(){ 5.07, 4.05, 3.04, 2.03, 1.01, 0 } },
            { "RESL",  new List<double>(){ 7.07, 5.65, 4.24, 2.83, 1.41, 0 } },
            { "TEAM", new List<double>(){ 5.48, 4.38, 3.29, 2.19, 1.1 , 0 } },
            { "PMAT", new List<double>(){ 7.8, 6.24, 4.68, 3.12, 1.56, 0 } },

        };

        public static Dictionary<string, double> sf = new Dictionary<string, double>()
        {
            {"PREC", 1 },
            {"FLEX", 1 },
            {"RESL", 1 },
            {"TEAM", 1 },
            {"PMAT", 1 },
        };


        public SFForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 5;

            dataGridView1[0, 0].Value = "PREC";
            dataGridView1[0, 1].Value = "FLEX";
            dataGridView1[0, 2].Value = "RESL";
            dataGridView1[0, 3].Value = "TEAM";
            dataGridView1[0, 4].Value = "PMAT";

            var keys = sfCoef.Keys;
            int j = 0;
            foreach (var key in keys) 
            {
                for (int i = 0; i < sfCoef[key].Count; i++)
                {
                    
                    dataGridView1[i + 1, j].Value = sfCoef[key][i];
                    
                }
                j++;
                
            }

        }

        private void setRate_Click(object sender, EventArgs e)
        {
            try
            {



                sf["PREC"] = Convert.ToDouble(dataGridView1[PRECCB.SelectedIndex + 1, 0].Value);
                sf["FLEX"] = Convert.ToDouble(dataGridView1[FLEXCB.SelectedIndex + 1, 1].Value);
                sf["RESL"] = Convert.ToDouble(dataGridView1[RESLCB.SelectedIndex + 1, 2].Value);
                sf["TEAM"] = Convert.ToDouble(dataGridView1[TEAMCB.SelectedIndex + 1, 3].Value);
                sf["PMAT"] = Convert.ToDouble(dataGridView1[PMATCB.SelectedIndex + 1, 4].Value);
            }
            catch(Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
