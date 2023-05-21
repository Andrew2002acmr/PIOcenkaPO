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
    public partial class EMDetailForm : Form
    {
        public static Dictionary<string, List<double>> emCoef = new Dictionary<string, List<double>>()
        {
            { "ACAP",  new List<double>(){ 1.42, 1.29, 1, 0.85, 0.71, -1} },
            { "AEXP", new List<double>(){ 1.22, 1.1, 1, 0.88, 0.81, -1 } },
            { "PCAP",  new List<double>(){ 1.34, 1.15, 1, 0.88, 0.76, -1} },
            { "PCON", new List<double>(){ 1.29, 1.12, 1, 0.9, 0.81, -1 } },
            { "PEXP", new List<double>(){ 1.2, 1.09, 1, 0.91, 0.85, -1} },
            { "LTEX", new List<double>(){ 1.2, 1.09, 1, 0.91, 0.84, -1} },
            { "RELY", new List<double>(){ 0.84, 0.92, 1, 1.1, 1.26, -1} },
            { "DATA", new List<double>(){-1, 0.23, 1, 1.14, 1.28, -1} },
            { "CPLX",  new List<double>(){ 0.73, 0.87, 1, 1.17, 1.34, 1.74 } },
            { "RUSE", new List<double>(){ -1, 0.95, 1, 1.07, 1.15, 1.24 } },
            { "DOCU",  new List<double>(){ 0.81, 0.91, 1, 1.11, 1.23, -1} },
            { "TIME", new List<double>(){ -1, -1, 1, 1.11, 1.29, 1.63 } },
            { "STOR", new List<double>(){ -1, -1, 1, 1.05, 1.17, 1.46} },
            { "PVOL", new List<double>(){ -1, 0.87, 1, 1.15, 1.3, -1} },
            { "TOOL", new List<double>(){ 1.17, 1.09, 1, 0.9, 0.78, -1} },
            { "SITE", new List<double>(){ 1.22, 1.09, 1, 0.93, 0.86, 0.8} },
            { "SCED", new List<double>(){ 1.43, 1.14, 1, 1, 1, -1} },

        };

        public static Dictionary<string, double> em = new Dictionary<string, double>()
        {
            {"ACAP", 1 },
            {"AEXP", 1 },
            {"PCAP", 1 },
            {"PCON", 1 },
            {"PEXP", 1 },
            {"LTEX", 1 },
            {"RELY", 1 },
            {"DATA", 1 },
            {"CPLX", 1 },
            {"RUSE", 1 },
            {"DOCU", 1 },
            {"TIME", 1 },
            {"STOR", 1 },
            {"PVOL", 1 },
            {"TOOL", 1 },
            {"SITE", 1 },
            {"SCED", 1 },
        };


        public EMDetailForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 17;
           
            dataGridView1[0, 0].Value = "ACAP";
            dataGridView1[0, 1].Value = "AEXP";
            dataGridView1[0, 2].Value = "PCAP";
            dataGridView1[0, 3].Value = "PCON";
            dataGridView1[0, 4].Value = "PEXP";
            dataGridView1[0, 5].Value = "LTEX";
            dataGridView1[0, 6].Value = "RELY";
            dataGridView1[0, 7].Value = "DATA";
            dataGridView1[0, 8].Value = "CPLX";
            dataGridView1[0, 9].Value = "RUSE";
            dataGridView1[0, 10].Value = "DOCU";
            dataGridView1[0, 11].Value = "TIME";
            dataGridView1[0, 12].Value = "STOR";
            dataGridView1[0, 13].Value = "PVOL";
            dataGridView1[0, 14].Value = "TOOL";
            dataGridView1[0, 15].Value = "SITE";
            dataGridView1[0, 16].Value = "SCED";

            var keys = emCoef.Keys;
            int j = 0;
            foreach (var key in keys)
            {
                for (int i = 0; i < emCoef[key].Count; i++)
                {
                    if (emCoef[key][i] != -1)
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
                if (Convert.ToString(dataGridView1[ACAPCB.SelectedIndex + 1, 0].Value) == "")
                {
                    MessageBox.Show("Множитель ACAP  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[AEXPCB.SelectedIndex + 1, 1].Value) == "")
                {
                    MessageBox.Show("Множитель AEXP  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[PCAPCB.SelectedIndex + 1, 2].Value) == "")
                {
                    MessageBox.Show("Множитель PCAP  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[PCONCB.SelectedIndex + 1, 3].Value) == "")
                {
                    MessageBox.Show("Множитель PCON  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[PEXPCB.SelectedIndex + 1, 4].Value) == "")
                {
                    MessageBox.Show("Множитель PEXP  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[LTEXCB.SelectedIndex + 1, 5].Value) == "")
                {
                    MessageBox.Show("Множитель LTEX  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[RELYCB.SelectedIndex + 1, 6].Value) == "")
                {
                    MessageBox.Show("Множитель RELY  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[DATACB.SelectedIndex + 1, 7].Value) == "")
                {
                    MessageBox.Show("Множитель DATA  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[CPLXCB.SelectedIndex + 1, 8].Value) == "")
                {
                    MessageBox.Show("Множитель CPLX  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[RUSECB.SelectedIndex + 1, 9].Value) == "")
                {
                    MessageBox.Show("Множитель RUSE  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[DOCUCB.SelectedIndex + 1, 10].Value) == "")
                {
                    MessageBox.Show("Множитель DOCU  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[TIMECB.SelectedIndex + 1, 11].Value) == "")
                {
                    MessageBox.Show("Множитель TIME  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[STORCB.SelectedIndex + 1, 11].Value) == "")
                {
                    MessageBox.Show("Множитель STOR  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[PVOLCB.SelectedIndex + 1, 12].Value) == "")
                {
                    MessageBox.Show("Множитель PVOL  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[TOOLCB.SelectedIndex + 1, 13].Value) == "")
                {
                    MessageBox.Show("Множитель TOOL  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[SITECB.SelectedIndex + 1, 14].Value) == "")
                {
                    MessageBox.Show("Множитель SITE  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[SCEDCB.SelectedIndex + 1, 15].Value) == "")
                {
                    MessageBox.Show("Множитель SCED  не считается для этого рейтинга");
                }
                else if (Convert.ToString(dataGridView1[RELYCB.SelectedIndex + 1, 16].Value) == "")
                {
                    MessageBox.Show("Множитель RELY  не считается для этого рейтинга");
                }
                else
                {
                    
                    em["ACAP"] = Convert.ToDouble(dataGridView1[ACAPCB.SelectedIndex + 1, 0].Value);
                    em["AEXP"] = Convert.ToDouble(dataGridView1[AEXPCB.SelectedIndex + 1, 1].Value);
                    em["PCAP"] = Convert.ToDouble(dataGridView1[PCAPCB.SelectedIndex + 1, 2].Value);
                    em["PCON"] = Convert.ToDouble(dataGridView1[PCONCB.SelectedIndex + 1, 3].Value);
                    em["PEXP"] = Convert.ToDouble(dataGridView1[PEXPCB.SelectedIndex + 1, 4].Value);
                    em["LTEX"] = Convert.ToDouble(dataGridView1[LTEXCB.SelectedIndex + 1, 5].Value);
                    em["RELY"] = Convert.ToDouble(dataGridView1[RELYCB.SelectedIndex + 1, 6].Value);
                    em["DATA"] = Convert.ToDouble(dataGridView1[DATACB.SelectedIndex + 1, 0].Value);
                    em["CPLX"] = Convert.ToDouble(dataGridView1[CPLXCB.SelectedIndex + 1, 1].Value);
                    em["RUSE"] = Convert.ToDouble(dataGridView1[RUSECB.SelectedIndex + 1, 2].Value);
                    em["DOCU"] = Convert.ToDouble(dataGridView1[DOCUCB.SelectedIndex + 1, 3].Value);
                    em["TIME"] = Convert.ToDouble(dataGridView1[TIMECB.SelectedIndex + 1, 4].Value);
                    em["STOR"] = Convert.ToDouble(dataGridView1[STORCB.SelectedIndex + 1, 5].Value);
                    em["PVOL"] = Convert.ToDouble(dataGridView1[PVOLCB.SelectedIndex + 1, 6].Value);
                    em["TOOL"] = Convert.ToDouble(dataGridView1[TOOLCB.SelectedIndex + 1, 4].Value);
                    em["SITE"] = Convert.ToDouble(dataGridView1[SITECB.SelectedIndex + 1, 5].Value);
                    em["SCED"] = Convert.ToDouble(dataGridView1[SCEDCB.SelectedIndex + 1, 6].Value);
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
