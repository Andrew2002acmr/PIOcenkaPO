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
    public partial class SIMethodForm : Form
    {
        private double j1 = 0;
        private double j2 = 0;


        public SIMethodForm()
        {
            InitializeComponent();

            siDGV.RowCount = 9;

            siDGV[0, 0].Value = "1. Удобство работы (пользовательский интерфейс)";
            siDGV[0, 1].Value = "2.Новизна (соответствие современным требованиям)";
            siDGV[0, 2].Value = "3.Соответствие профилю деятельности заказчика";
            siDGV[0, 3].Value = "4.Ресурсная эффективность";
            siDGV[0, 4].Value = "5. Надежность (защита данных)";
            siDGV[0, 5].Value = "6.Скорость доступа к данным ";
            siDGV[0, 6].Value = "7.Гибкость настройки ";
            siDGV[0, 7].Value = "8.Обучаемость персонала";
            siDGV[0, 8].Value = "9.Соотношение стоимость/возможности ";

            siDGV[1, 0].Value = 0.14;
            siDGV[1, 1].Value = 0.1;
            siDGV[1, 2].Value = 0.2;
            siDGV[1, 3].Value = 0.05;
            siDGV[1, 4].Value = 0.13;
            siDGV[1, 5].Value = 0.1;
            siDGV[1, 6].Value = 0.06;
            siDGV[1, 7].Value = 0.13;
            siDGV[1, 8].Value = 0.09;

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            resDGV.RowCount = 1;

            j1 = 0;
            j2 = 0;

            try
            {
                for (int i = 0; i < siDGV.Rows.Count; i++)
                {
                    if (Convert.ToString(siDGV[0, i].Value) != "")
                    {
                        double xb1 = Convert.ToDouble(siDGV[2, i].Value) * Convert.ToDouble(siDGV[1, i].Value);
                        double xb2 = Convert.ToDouble(siDGV[4, i].Value) * Convert.ToDouble(siDGV[1, i].Value);
                        j1 += xb1;
                        j2 += xb2;
                        siDGV[3, i].Value = xb1;
                        siDGV[5, i].Value = xb2;
                    }
                }

                resDGV[0, 0].Value = Math.Round(j1, 2);
                resDGV[1, 0].Value = Math.Round(j2, 2);
                resDGV[2, 0].Value = Math.Round(j1 / j2, 2);

                Form1.ak = j1 / j2;

            }
            catch(Exception excp)
            {
                MessageBox.Show("Что-то пошло не так\n\n" + excp.Message);
            }

        }
    }
}
