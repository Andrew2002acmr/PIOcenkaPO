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
    public partial class ChoiseRateForm : Form
    {


        public ChoiseRateForm(string paramName)
        {
            InitializeComponent();

            label1.Text = "Рейтинг атрибута:  " + paramName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntermediateCOCOMOForm.atrRate.Add(comboBox2.SelectedIndex);
            Close();
        }
    }
}
