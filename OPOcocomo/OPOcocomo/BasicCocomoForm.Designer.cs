namespace OPOcocomo
{
    partial class BasicCocomoForm
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
            this.calculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 112);
            this.dataGridView1.TabIndex = 0;
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
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(313, 381);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(123, 25);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Расчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество строк";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pm,
            this.tm});
            this.dataGridView2.Location = new System.Drawing.Point(12, 181);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 116);
            this.dataGridView2.TabIndex = 4;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Распространенный",
            "Полунезависимый",
            "Встроенный"});
            this.comboBox1.Location = new System.Drawing.Point(135, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // BasicCocomoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BasicCocomoForm";
            this.Text = "BasicCocomoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tm;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}