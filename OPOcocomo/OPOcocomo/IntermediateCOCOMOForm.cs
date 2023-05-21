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
    public partial class IntermediateCOCOMOForm : Form
    {

        public static List<int> atrRate = new List<int>();
        
        public IntermediateCOCOMOForm()
        {
            InitializeComponent();

            dataGridView1.RowCount = 3;


            dataGridView1[0, 0].Value = "Распространенный";
            dataGridView1[0, 1].Value = "Полунезависимый";
            dataGridView1[0, 2].Value = "Встроенный";

            dataGridView1[1, 0].Value = 3.2;
            dataGridView1[1, 1].Value = 3;
            dataGridView1[1, 2].Value = 2.8;

            dataGridView1[2, 0].Value = 1.05;
            dataGridView1[2, 1].Value = 1.12;
            dataGridView1[2, 2].Value = 1.2;

            dataGridView1[3, 0].Value = 2.5;
            dataGridView1[3, 1].Value = 2.5;
            dataGridView1[3, 2].Value = 2.5;

            dataGridView1[4, 0].Value = 0.38;
            dataGridView1[4, 1].Value = 0.35;
            dataGridView1[4, 2].Value = 0.32;

            dataGridView2.RowCount = 15;

            dataGridView2[0, 0].Value = "1. Требуемая надежность ПО";
            dataGridView2[0, 1].Value = "2. Размер БД приложения ";
            dataGridView2[0, 2].Value = "3. Сложность продукта";
            dataGridView2[0, 3].Value = "4. Ограничения быстродействия при выполнении программы";
            dataGridView2[0, 4].Value = "5. Ограничения памяти ";
            dataGridView2[0, 5].Value = "6. Неустойчивость окружения виртуальной машины";
            dataGridView2[0, 6].Value = "7. Требуемое время восстановления";
            dataGridView2[0, 7].Value = "8. Аналитические способности";
            dataGridView2[0, 8].Value = "9. Опыт разработки";
            dataGridView2[0, 9].Value = "10. Способности к разработке ПО ";
            dataGridView2[0, 10].Value = "11. Опыт использования виртуальных машин";
            dataGridView2[0, 11].Value = "12. Опыт разработки на языках программирования";
            dataGridView2[0, 12].Value = "13. Применение методов разработки ПО";
            dataGridView2[0, 13].Value = "14. Использование инструментария разработки ПО";
            dataGridView2[0, 14].Value = "15. Требования соблюдения графика разработки";

            /*Заполнение коэфициентов*/

            dataGridView2[1, 0].Value = 0.75;
            dataGridView2[1, 1].Value = 1;
            dataGridView2[1, 2].Value = 0.7;
            dataGridView2[1, 3].Value = 1;
            dataGridView2[1, 4].Value = 1;
            dataGridView2[1, 5].Value = 1;
            dataGridView2[1, 6].Value = 1;
            dataGridView2[1, 7].Value = 1.46;
            dataGridView2[1, 8].Value = 1.29;
            dataGridView2[1, 9].Value = 1.42;
            dataGridView2[1, 10].Value = 1.21;
            dataGridView2[1, 11].Value = 1.14;
            dataGridView2[1, 12].Value = 1.24;
            dataGridView2[1, 13].Value = 1.24;
            dataGridView2[1, 14].Value = 1.23;

            dataGridView2[2, 0].Value = 0.88;
            dataGridView2[2, 1].Value = 0.94;
            dataGridView2[2, 2].Value = 0.95;
            dataGridView2[2, 3].Value = 1;
            dataGridView2[2, 4].Value = 1;
            dataGridView2[2, 5].Value = 0.87;
            dataGridView2[2, 6].Value = 0.87;
            dataGridView2[2, 7].Value = 1.19;
            dataGridView2[2, 8].Value = 1.13;
            dataGridView2[2, 9].Value = 1.17;
            dataGridView2[2, 10].Value = 1.1;
            dataGridView2[2, 11].Value = 1.07;
            dataGridView2[2, 12].Value = 1.1;
            dataGridView2[2, 13].Value = 1.1;
            dataGridView2[2, 14].Value = 1.08;

            dataGridView2[3, 0].Value = 1;
            dataGridView2[3, 1].Value = 1;
            dataGridView2[3, 2].Value = 1;
            dataGridView2[3, 3].Value = 1;
            dataGridView2[3, 4].Value = 1;
            dataGridView2[3, 5].Value = 1;
            dataGridView2[3, 6].Value = 1;
            dataGridView2[3, 7].Value = 1;
            dataGridView2[3, 8].Value = 1;
            dataGridView2[3, 9].Value = 1;
            dataGridView2[3, 10].Value = 1;
            dataGridView2[3, 11].Value = 1;
            dataGridView2[3, 12].Value = 1;
            dataGridView2[3, 13].Value = 1;
            dataGridView2[3, 14].Value = 1;

            dataGridView2[4, 0].Value = 1.15;
            dataGridView2[4, 1].Value = 1.08;
            dataGridView2[4, 2].Value = 1.15;
            dataGridView2[4, 3].Value = 1.11;
            dataGridView2[4, 4].Value = 1.06;
            dataGridView2[4, 5].Value = 1.15;
            dataGridView2[4, 6].Value = 1.07;
            dataGridView2[4, 7].Value = 0.86;
            dataGridView2[4, 8].Value = 0.91;
            dataGridView2[4, 9].Value = 0.86;
            dataGridView2[4, 10].Value = 0.9;
            dataGridView2[4, 11].Value = 0.95;
            dataGridView2[4, 12].Value = 0.91;
            dataGridView2[4, 13].Value = 0.91;
            dataGridView2[4, 14].Value = 1.04;

            dataGridView2[5, 0].Value = 1.4;
            dataGridView2[5, 1].Value = 1.16;
            dataGridView2[5, 2].Value = 1.3;
            dataGridView2[5, 3].Value = 1.3;
            dataGridView2[5, 4].Value = 1.21;
            dataGridView2[5, 5].Value = 1.3;
            dataGridView2[5, 6].Value = 1.15;
            dataGridView2[5, 7].Value = 0.71;
            dataGridView2[5, 8].Value = 0.82;
            dataGridView2[5, 9].Value = 0.7;
            dataGridView2[5, 10].Value = 1;
            dataGridView2[5, 11].Value = 1;
            dataGridView2[5, 12].Value = 0.82;
            dataGridView2[5, 13].Value = 0.83;
            dataGridView2[5, 14].Value = 1.1;

            dataGridView2[6, 0].Value = 1;
            dataGridView2[6, 1].Value = 1;
            dataGridView2[6, 2].Value = 1.65;
            dataGridView2[6, 3].Value = 1.56;
            dataGridView2[6, 4].Value = 1;
            dataGridView2[6, 5].Value = 1;
            dataGridView2[6, 6].Value = 1;
            dataGridView2[6, 7].Value = 1;
            dataGridView2[6, 8].Value = 1;
            dataGridView2[6, 9].Value = 1;
            dataGridView2[6, 10].Value = 1;
            dataGridView2[6, 11].Value = 1;
            dataGridView2[6, 12].Value = 1;
            dataGridView2[6, 13].Value = 1;
            dataGridView2[6, 14].Value = 1;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                atrRate = new List<int>();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    ChoiseRateForm choiseRate = new ChoiseRateForm(Convert.ToString(dataGridView2[0, i].Value));
                    choiseRate.ShowDialog();
                }


                int size = Convert.ToInt32(textBox1.Text);
                int idType = comboBox1.SelectedIndex;


                double eaf = 1;

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    
                    int idRate = atrRate[i] + 1;
                    if (Convert.ToString(dataGridView2[idRate, i].Value) == "")
                    {
                        dataGridView2[idRate, i].Value = 1;
                    }

                    eaf = eaf * Convert.ToDouble(dataGridView2[idRate, i].Value);
                    
                    
                }


                double pm = eaf * Convert.ToDouble(dataGridView1[1, idType].Value) * Math.Pow(size, Convert.ToDouble(dataGridView1[2, idType].Value));
                double tm = Convert.ToDouble(dataGridView1[3, comboBox1.SelectedIndex].Value) * Math.Pow(pm, Convert.ToDouble(dataGridView1[4, comboBox1.SelectedIndex].Value));

                dataGridView3.RowCount = 1;

                dataGridView3[0, 0].Value = pm;
                dataGridView3[1, 0].Value = tm;
                dataGridView3[2, 0].Value = eaf;

            }
            catch (Exception excp)
            {
                MessageBox.Show("Ошибка\n\n" + excp.Message);
            }
        }
    }
}
