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
    public partial class Form1 : Form
    {
        public static List<string> emps = new List<string>() { "Руководитель", "Программист"};
        public static double ak = 1.6;
        public static double ef = 0;
        public static double e = 0;
        public static double term = 0;
        public static double yearCost = 0;
        public static double costs = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIMethodForm sIMethodForm = new SIMethodForm();

            sIMethodForm.Show();
        }

        private void ComplexW_Click(object sender, EventArgs e)
        {
            CWForm cWForm = new CWForm();  

            cWForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryForm sSalaryForm = new SalaryForm();  
            sSalaryForm.Show();
        }

        private void devCost_Click(object sender, EventArgs e)
        {
            DevCostForm devCostForm = new DevCostForm();
            devCostForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YearCostsForm yearCostsForm = new YearCostsForm();
            yearCostsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EeffectForm eeffectForm = new EeffectForm();
            eeffectForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JuctificationForm juctificationForm = new JuctificationForm();  
            juctificationForm.Show();
        }
    }
}
