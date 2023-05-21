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
    public partial class CocomoIIForm : Form
    {
        double a = 2.45;    
        double aEarly = 2.94;
        double b = 0.91;
        double c = 3.67;
        double d = 0.28;
        double E;
        double pm;
        double pmEarly;
        double tm;
        double tmEarly;
        double eaf;
        double em;
        double emEarly;
        double sf;
        double pmns;
        double pmnsEarly;

        public CocomoIIForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 1;

            dataGridView2[0, 0].Value = a;
            dataGridView2[1, 0].Value = aEarly;
            dataGridView2[2, 0].Value = b;
            dataGridView2[3, 0].Value = c;
            dataGridView2[4, 0].Value = d;

        }

        private void факторыМасштабаSFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFForm sfForm = new SFForm();
            sfForm.ShowDialog();
        }

        private void eMПредварительноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EMEarlyForm eMEarlyForm = new EMEarlyForm();

            eMEarlyForm.ShowDialog();
        }

        private void eMДетальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EMDetailForm eMDetailForm = new EMDetailForm();

            eMDetailForm.ShowDialog();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, double> sfDict = SFForm.sf;
                Dictionary<string, double> emEarlyDict = EMEarlyForm.em;
                Dictionary<string, double> emDict = EMDetailForm.em;

                a = Convert.ToDouble(dataGridView2[0, 0].Value);
                aEarly = Convert.ToDouble(dataGridView2[1, 0].Value);
                b = Convert.ToDouble(dataGridView2[2, 0].Value);
                c = Convert.ToDouble(dataGridView2[3, 0].Value);
                d = Convert.ToDouble(dataGridView2[4, 0].Value);
                int size = Convert.ToInt32(textBox1.Text);

                eaf = 1;
                em = 1;
                emEarly = 1;
                E = 1;
                pmns = 1;
                pmnsEarly = 1;
                foreach (var l in emEarlyDict)
                {
                    emEarly = emEarly * l.Value;
                    if (l.Key != "SCED")
                    {
                        pmnsEarly = pmnsEarly * l.Value;
                    }
                }

                foreach (var l in emDict)
                {
                    em = em * l.Value;
                    if (l.Key != "SCED")
                    {
                        pmns = pmns * l.Value;
                    }
                }

                foreach (var l in sfDict)
                {
                    sf = sf * l.Value;
                }


                E = b + (0.01 * sf);

                pmEarly = emEarly * aEarly * Math.Pow(size, E);
                pm = em * a * Math.Pow(size, E);

                tmEarly = emEarlyDict["SCED"] * c * Math.Pow(pmnsEarly, d + (0.2 * (E - b)));
                tm = emDict["SCED"] * c * Math.Pow(pmns, d + (0.2 * (E - b)));

                dataGridView1.RowCount = 1;

                dataGridView1[0, 0].Value = pmEarly;
                dataGridView1[1, 0].Value = pm;
                dataGridView1[2, 0].Value = tmEarly;
                dataGridView1[3, 0].Value = tm;
                dataGridView1[4, 0].Value = emEarly;
                dataGridView1[5, 0].Value = em;
                dataGridView1[6, 0].Value = pmnsEarly;
                dataGridView1[7, 0].Value = pmns;

            }
            catch(Exception excp)
            {
                MessageBox.Show(excp.Message);
            }
        }
    }
}
