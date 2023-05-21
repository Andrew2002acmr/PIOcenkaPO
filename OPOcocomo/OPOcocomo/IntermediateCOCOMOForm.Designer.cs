namespace OPOcocomo
{
    partial class IntermediateCOCOMOForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veryLowRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veryHighRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraHighRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameType,
            this.parA,
            this.parb,
            this.parC,
            this.parD});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 112);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameType
            // 
            this.nameType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameType.HeaderText = "Тип проекта";
            this.nameType.Name = "nameType";
            // 
            // parA
            // 
            this.parA.HeaderText = "a";
            this.parA.Name = "parA";
            // 
            // parb
            // 
            this.parb.HeaderText = "b";
            this.parb.Name = "parb";
            // 
            // parC
            // 
            this.parC.HeaderText = "c";
            this.parC.Name = "parC";
            // 
            // parD
            // 
            this.parD.HeaderText = "d";
            this.parD.Name = "parD";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.veryLowRate,
            this.LowRate,
            this.normRate,
            this.highRate,
            this.veryHighRate,
            this.extraHighRate});
            this.dataGridView2.Location = new System.Drawing.Point(12, 203);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(845, 131);
            this.dataGridView2.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Атрибуты стоимости, CDk";
            this.name.Name = "name";
            // 
            // veryLowRate
            // 
            this.veryLowRate.HeaderText = "Очень низкий";
            this.veryLowRate.Name = "veryLowRate";
            // 
            // LowRate
            // 
            this.LowRate.HeaderText = "Низкий";
            this.LowRate.Name = "LowRate";
            // 
            // normRate
            // 
            this.normRate.HeaderText = "Средний";
            this.normRate.Name = "normRate";
            // 
            // highRate
            // 
            this.highRate.HeaderText = "Высокий";
            this.highRate.Name = "highRate";
            // 
            // veryHighRate
            // 
            this.veryHighRate.HeaderText = "Очень высокий";
            this.veryHighRate.Name = "veryHighRate";
            // 
            // extraHighRate
            // 
            this.extraHighRate.HeaderText = "Критический";
            this.extraHighRate.Name = "extraHighRate";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Распространенный",
            "Полунезависимый",
            "Встроенный"});
            this.comboBox1.Location = new System.Drawing.Point(135, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество строк";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(312, 502);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(184, 51);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Расчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pm,
            this.tm,
            this.eaf});
            this.dataGridView3.Location = new System.Drawing.Point(15, 356);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(842, 116);
            this.dataGridView3.TabIndex = 10;
            // 
            // pm
            // 
            this.pm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pm.HeaderText = "PM";
            this.pm.Name = "pm";
            // 
            // tm
            // 
            this.tm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tm.HeaderText = "TM";
            this.tm.Name = "tm";
            // 
            // eaf
            // 
            this.eaf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eaf.HeaderText = "EAF";
            this.eaf.Name = "eaf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип проекта";
            // 
            // IntermediateCOCOMOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IntermediateCOCOMOForm";
            this.Text = "IntermediateCOCOMOForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn parA;
        private System.Windows.Forms.DataGridViewTextBoxColumn parb;
        private System.Windows.Forms.DataGridViewTextBoxColumn parC;
        private System.Windows.Forms.DataGridViewTextBoxColumn parD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn veryLowRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn normRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn highRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn veryHighRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraHighRate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tm;
        private System.Windows.Forms.DataGridViewTextBoxColumn eaf;
        private System.Windows.Forms.Label label2;
    }
}