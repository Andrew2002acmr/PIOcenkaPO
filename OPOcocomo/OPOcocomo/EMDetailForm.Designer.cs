namespace OPOcocomo
{
    partial class EMDetailForm
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
            this.RELYCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LTEXCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setRate = new System.Windows.Forms.Button();
            this.PEXPCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PCONCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PCAPCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AEXPCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ACAPCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeryLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATACB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SITECB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TOOLCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PVOLCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.STORCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TIMECB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DOCUCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RUSECB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CPLXCB = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SCEDCB = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RELYCB
            // 
            this.RELYCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RELYCB.FormattingEnabled = true;
            this.RELYCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.RELYCB.Location = new System.Drawing.Point(274, 285);
            this.RELYCB.Name = "RELYCB";
            this.RELYCB.Size = new System.Drawing.Size(121, 21);
            this.RELYCB.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "RELY";
            // 
            // LTEXCB
            // 
            this.LTEXCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LTEXCB.FormattingEnabled = true;
            this.LTEXCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.LTEXCB.Location = new System.Drawing.Point(274, 243);
            this.LTEXCB.Name = "LTEXCB";
            this.LTEXCB.Size = new System.Drawing.Size(121, 21);
            this.LTEXCB.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "LTEX";
            // 
            // setRate
            // 
            this.setRate.Location = new System.Drawing.Point(548, 488);
            this.setRate.Name = "setRate";
            this.setRate.Size = new System.Drawing.Size(331, 57);
            this.setRate.TabIndex = 52;
            this.setRate.Text = "Установить рейтинг";
            this.setRate.UseVisualStyleBackColor = true;
            this.setRate.Click += new System.EventHandler(this.setRate_Click);
            // 
            // PEXPCB
            // 
            this.PEXPCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PEXPCB.FormattingEnabled = true;
            this.PEXPCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.PEXPCB.Location = new System.Drawing.Point(274, 204);
            this.PEXPCB.Name = "PEXPCB";
            this.PEXPCB.Size = new System.Drawing.Size(121, 21);
            this.PEXPCB.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "PEXP";
            // 
            // PCONCB
            // 
            this.PCONCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PCONCB.FormattingEnabled = true;
            this.PCONCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.PCONCB.Location = new System.Drawing.Point(78, 323);
            this.PCONCB.Name = "PCONCB";
            this.PCONCB.Size = new System.Drawing.Size(121, 21);
            this.PCONCB.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "PCON";
            // 
            // PCAPCB
            // 
            this.PCAPCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PCAPCB.FormattingEnabled = true;
            this.PCAPCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.PCAPCB.Location = new System.Drawing.Point(78, 285);
            this.PCAPCB.Name = "PCAPCB";
            this.PCAPCB.Size = new System.Drawing.Size(121, 21);
            this.PCAPCB.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "PCAP";
            // 
            // AEXPCB
            // 
            this.AEXPCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AEXPCB.FormattingEnabled = true;
            this.AEXPCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.AEXPCB.Location = new System.Drawing.Point(78, 243);
            this.AEXPCB.Name = "AEXPCB";
            this.AEXPCB.Size = new System.Drawing.Size(121, 21);
            this.AEXPCB.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "AEXP";
            // 
            // ACAPCB
            // 
            this.ACAPCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ACAPCB.FormattingEnabled = true;
            this.ACAPCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.ACAPCB.Location = new System.Drawing.Point(78, 204);
            this.ACAPCB.Name = "ACAPCB";
            this.ACAPCB.Size = new System.Drawing.Size(121, 21);
            this.ACAPCB.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "ACAP";
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 171);
            this.dataGridView1.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Множитель трудоёмкости, EMi";
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
            // DATACB
            // 
            this.DATACB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DATACB.FormattingEnabled = true;
            this.DATACB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.DATACB.Location = new System.Drawing.Point(274, 323);
            this.DATACB.Name = "DATACB";
            this.DATACB.Size = new System.Drawing.Size(121, 21);
            this.DATACB.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "DATA";
            // 
            // SITECB
            // 
            this.SITECB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SITECB.FormattingEnabled = true;
            this.SITECB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.SITECB.Location = new System.Drawing.Point(646, 323);
            this.SITECB.Name = "SITECB";
            this.SITECB.Size = new System.Drawing.Size(121, 21);
            this.SITECB.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "SITE";
            // 
            // TOOLCB
            // 
            this.TOOLCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TOOLCB.FormattingEnabled = true;
            this.TOOLCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.TOOLCB.Location = new System.Drawing.Point(646, 285);
            this.TOOLCB.Name = "TOOLCB";
            this.TOOLCB.Size = new System.Drawing.Size(121, 21);
            this.TOOLCB.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "TOOL";
            // 
            // PVOLCB
            // 
            this.PVOLCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PVOLCB.FormattingEnabled = true;
            this.PVOLCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.PVOLCB.Location = new System.Drawing.Point(646, 243);
            this.PVOLCB.Name = "PVOLCB";
            this.PVOLCB.Size = new System.Drawing.Size(121, 21);
            this.PVOLCB.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "PVOL";
            // 
            // STORCB
            // 
            this.STORCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STORCB.FormattingEnabled = true;
            this.STORCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.STORCB.Location = new System.Drawing.Point(646, 204);
            this.STORCB.Name = "STORCB";
            this.STORCB.Size = new System.Drawing.Size(121, 21);
            this.STORCB.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "STOR";
            // 
            // TIMECB
            // 
            this.TIMECB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TIMECB.FormattingEnabled = true;
            this.TIMECB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.TIMECB.Location = new System.Drawing.Point(450, 323);
            this.TIMECB.Name = "TIMECB";
            this.TIMECB.Size = new System.Drawing.Size(121, 21);
            this.TIMECB.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "TIME";
            // 
            // DOCUCB
            // 
            this.DOCUCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DOCUCB.FormattingEnabled = true;
            this.DOCUCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.DOCUCB.Location = new System.Drawing.Point(450, 285);
            this.DOCUCB.Name = "DOCUCB";
            this.DOCUCB.Size = new System.Drawing.Size(121, 21);
            this.DOCUCB.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(408, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "DOCU";
            // 
            // RUSECB
            // 
            this.RUSECB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RUSECB.FormattingEnabled = true;
            this.RUSECB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.RUSECB.Location = new System.Drawing.Point(450, 243);
            this.RUSECB.Name = "RUSECB";
            this.RUSECB.Size = new System.Drawing.Size(121, 21);
            this.RUSECB.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(408, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "RUSE";
            // 
            // CPLXCB
            // 
            this.CPLXCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CPLXCB.FormattingEnabled = true;
            this.CPLXCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.CPLXCB.Location = new System.Drawing.Point(450, 204);
            this.CPLXCB.Name = "CPLXCB";
            this.CPLXCB.Size = new System.Drawing.Size(121, 21);
            this.CPLXCB.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(408, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "CPLX";
            // 
            // SCEDCB
            // 
            this.SCEDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SCEDCB.FormattingEnabled = true;
            this.SCEDCB.Items.AddRange(new object[] {
            "Очень низкий",
            "Низкий",
            "Средний",
            "Высокий",
            "Очень высокий",
            "Критический"});
            this.SCEDCB.Location = new System.Drawing.Point(848, 204);
            this.SCEDCB.Name = "SCEDCB";
            this.SCEDCB.Size = new System.Drawing.Size(121, 21);
            this.SCEDCB.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(806, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "SCED";
            // 
            // EMDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 583);
            this.Controls.Add(this.SCEDCB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SITECB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TOOLCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PVOLCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.STORCB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TIMECB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DOCUCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RUSECB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CPLXCB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DATACB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RELYCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LTEXCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.setRate);
            this.Controls.Add(this.PEXPCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PCONCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PCAPCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AEXPCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ACAPCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EMDetailForm";
            this.Text = "EMDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RELYCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox LTEXCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setRate;
        private System.Windows.Forms.ComboBox PEXPCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PCONCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PCAPCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AEXPCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ACAPCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeryLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox DATACB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SITECB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TOOLCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PVOLCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox STORCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TIMECB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox DOCUCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox RUSECB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CPLXCB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox SCEDCB;
        private System.Windows.Forms.Label label17;
    }
}