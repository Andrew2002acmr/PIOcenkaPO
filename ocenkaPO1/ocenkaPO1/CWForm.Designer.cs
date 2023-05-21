namespace ocenkaPO1
{
    partial class CWForm
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
            this.AddEmps = new System.Windows.Forms.Button();
            this.worksDGV = new System.Windows.Forms.DataGridView();
            this.empsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateSchedule = new System.Windows.Forms.Button();
            this.startDateTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.worksDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmps
            // 
            this.AddEmps.Location = new System.Drawing.Point(12, 24);
            this.AddEmps.Name = "AddEmps";
            this.AddEmps.Size = new System.Drawing.Size(189, 39);
            this.AddEmps.TabIndex = 2;
            this.AddEmps.Text = "Добавить сотрудников";
            this.AddEmps.UseVisualStyleBackColor = true;
            this.AddEmps.Click += new System.EventHandler(this.AddEmps_Click);
            // 
            // worksDGV
            // 
            this.worksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.work,
            this.days});
            this.worksDGV.Location = new System.Drawing.Point(12, 100);
            this.worksDGV.Name = "worksDGV";
            this.worksDGV.Size = new System.Drawing.Size(366, 304);
            this.worksDGV.TabIndex = 3;
            // 
            // empsDGV
            // 
            this.empsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empsDGV.Location = new System.Drawing.Point(384, 100);
            this.empsDGV.Name = "empsDGV";
            this.empsDGV.Size = new System.Drawing.Size(290, 304);
            this.empsDGV.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(680, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(132, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(822, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(131, 304);
            this.dataGridView2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата начала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата окончания";
            // 
            // calculateSchedule
            // 
            this.calculateSchedule.Location = new System.Drawing.Point(460, 24);
            this.calculateSchedule.Name = "calculateSchedule";
            this.calculateSchedule.Size = new System.Drawing.Size(171, 39);
            this.calculateSchedule.TabIndex = 9;
            this.calculateSchedule.Text = "Составить график работ";
            this.calculateSchedule.UseVisualStyleBackColor = true;
            this.calculateSchedule.Click += new System.EventHandler(this.calculateSchedule_Click);
            // 
            // startDateTB
            // 
            this.startDateTB.Location = new System.Drawing.Point(354, 34);
            this.startDateTB.Name = "startDateTB";
            this.startDateTB.Size = new System.Drawing.Size(100, 20);
            this.startDateTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата начала работ";
            // 
            // work
            // 
            this.work.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.work.HeaderText = "Содержание работ";
            this.work.Name = "work";
            // 
            // days
            // 
            this.days.HeaderText = "Дни";
            this.days.Name = "days";
            // 
            // CWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDateTB);
            this.Controls.Add(this.calculateSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.empsDGV);
            this.Controls.Add(this.worksDGV);
            this.Controls.Add(this.AddEmps);
            this.Name = "CWForm";
            this.Text = "CWForm";
            ((System.ComponentModel.ISupportInitialize)(this.worksDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddEmps;
        private System.Windows.Forms.DataGridView worksDGV;
        private System.Windows.Forms.DataGridView empsDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateSchedule;
        private System.Windows.Forms.TextBox startDateTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn work;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
    }
}