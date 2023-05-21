namespace OPOcocomo
{
    partial class SFForm
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeryLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PRECCB = new System.Windows.Forms.ComboBox();
            this.FLEXCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RESLCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TEAMCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PMATCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.setRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.VeryLow,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Фактор масштаба, SFj";
            this.Column1.Name = "Column1";
            // 
            // VeryLow
            // 
            this.VeryLow.HeaderText = "Очень низкий";
            this.VeryLow.Name = "VeryLow";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Низкий";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номинальный";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Высокий";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Очень высокий";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Критический";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PREC";
            // 
            // PRECCB
            // 
            this.PRECCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PRECCB.FormattingEnabled = true;
            this.PRECCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.PRECCB.Location = new System.Drawing.Point(94, 219);
            this.PRECCB.Name = "PRECCB";
            this.PRECCB.Size = new System.Drawing.Size(121, 21);
            this.PRECCB.TabIndex = 15;
            // 
            // FLEXCB
            // 
            this.FLEXCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FLEXCB.FormattingEnabled = true;
            this.FLEXCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.FLEXCB.Location = new System.Drawing.Point(94, 258);
            this.FLEXCB.Name = "FLEXCB";
            this.FLEXCB.Size = new System.Drawing.Size(121, 21);
            this.FLEXCB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "FLEX";
            // 
            // RESLCB
            // 
            this.RESLCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RESLCB.FormattingEnabled = true;
            this.RESLCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.RESLCB.Location = new System.Drawing.Point(94, 300);
            this.RESLCB.Name = "RESLCB";
            this.RESLCB.Size = new System.Drawing.Size(121, 21);
            this.RESLCB.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "RESL";
            // 
            // TEAMCB
            // 
            this.TEAMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TEAMCB.FormattingEnabled = true;
            this.TEAMCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.TEAMCB.Location = new System.Drawing.Point(94, 347);
            this.TEAMCB.Name = "TEAMCB";
            this.TEAMCB.Size = new System.Drawing.Size(121, 21);
            this.TEAMCB.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TEAM";
            // 
            // PMATCB
            // 
            this.PMATCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PMATCB.FormattingEnabled = true;
            this.PMATCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.PMATCB.Location = new System.Drawing.Point(290, 219);
            this.PMATCB.Name = "PMATCB";
            this.PMATCB.Size = new System.Drawing.Size(121, 21);
            this.PMATCB.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "PMAT";
            // 
            // setRate
            // 
            this.setRate.Location = new System.Drawing.Point(543, 217);
            this.setRate.Name = "setRate";
            this.setRate.Size = new System.Drawing.Size(331, 57);
            this.setRate.TabIndex = 24;
            this.setRate.Text = "Установить рейтинг";
            this.setRate.UseVisualStyleBackColor = true;
            this.setRate.Click += new System.EventHandler(this.setRate_Click);
            // 
            // SFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.setRate);
            this.Controls.Add(this.PMATCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TEAMCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RESLCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FLEXCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PRECCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SFForm";
            this.Text = "SFForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeryLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PRECCB;
        private System.Windows.Forms.ComboBox FLEXCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RESLCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TEAMCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PMATCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button setRate;
    }
}