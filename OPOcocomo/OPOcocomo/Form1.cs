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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cocomoBasicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicCocomoForm basicCocomoForm = new BasicCocomoForm();

            basicCocomoForm.Show();
        }

        private void intermediateCOCOMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntermediateCOCOMOForm intermediateCOCOMOForm = new IntermediateCOCOMOForm();

            intermediateCOCOMOForm.Show();
        }

        private void cocomoIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CocomoIIForm cocomoIIForm = new CocomoIIForm();

            cocomoIIForm.Show();
        }
    }
}
