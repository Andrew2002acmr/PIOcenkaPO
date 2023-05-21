namespace ocenkaPO1
{
    partial class SIMethodForm
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
            this.siDGV = new System.Windows.Forms.DataGridView();
            this.paramsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectXj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analogX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analogXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculate = new System.Windows.Forms.Button();
            this.resDGV = new System.Windows.Forms.DataGridView();
            this.Jetu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jetu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.siDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // siDGV
            // 
            this.siDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramsName,
            this.coefB,
            this.projectXj,
            this.projectXB,
            this.analogX,
            this.analogXB});
            this.siDGV.Location = new System.Drawing.Point(12, 12);
            this.siDGV.Name = "siDGV";
            this.siDGV.Size = new System.Drawing.Size(729, 268);
            this.siDGV.TabIndex = 0;
            // 
            // paramsName
            // 
            this.paramsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paramsName.HeaderText = "Показатели качества";
            this.paramsName.Name = "paramsName";
            // 
            // coefB
            // 
            this.coefB.HeaderText = "Коэффициент весомости, Bj";
            this.coefB.Name = "coefB";
            // 
            // projectXj
            // 
            this.projectXj.HeaderText = "Проект, Xj";
            this.projectXj.Name = "projectXj";
            // 
            // projectXB
            // 
            this.projectXB.HeaderText = "Проект, Xj x Bj";
            this.projectXB.Name = "projectXB";
            // 
            // analogX
            // 
            this.analogX.HeaderText = "Аналог, Xj";
            this.analogX.Name = "analogX";
            // 
            // analogXB
            // 
            this.analogXB.HeaderText = "Аналог, Xj x Bj";
            this.analogXB.Name = "analogXB";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(278, 430);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(211, 58);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Получить Jэту";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // resDGV
            // 
            this.resDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jetu1,
            this.Jetu2,
            this.Ak});
            this.resDGV.Enabled = false;
            this.resDGV.Location = new System.Drawing.Point(12, 298);
            this.resDGV.Name = "resDGV";
            this.resDGV.Size = new System.Drawing.Size(718, 100);
            this.resDGV.TabIndex = 2;
            // 
            // Jetu1
            // 
            this.Jetu1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jetu1.HeaderText = "JЭТУ1";
            this.Jetu1.Name = "Jetu1";
            // 
            // Jetu2
            // 
            this.Jetu2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jetu2.HeaderText = "JЭТУ2";
            this.Jetu2.Name = "Jetu2";
            // 
            // Ak
            // 
            this.Ak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ak.HeaderText = "Ak";
            this.Ak.Name = "Ak";
            // 
            // SIMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.resDGV);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.siDGV);
            this.Name = "SIMethodForm";
            this.Text = "SIMethodForm";
            ((System.ComponentModel.ISupportInitialize)(this.siDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView siDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefB;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectXj;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn analogX;
        private System.Windows.Forms.DataGridViewTextBoxColumn analogXB;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataGridView resDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jetu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jetu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ak;
    }
}