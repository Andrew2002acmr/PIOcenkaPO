namespace ocenkaPO1
{
    partial class YearCostsForm
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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analogCosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sumProj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumAnalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.projCost,
            this.analogCosts});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Статьи затрат";
            this.name.Name = "name";
            // 
            // projCost
            // 
            this.projCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projCost.HeaderText = "Затраты на проект, руб.";
            this.projCost.Name = "projCost";
            // 
            // analogCosts
            // 
            this.analogCosts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.analogCosts.HeaderText = "Затраты на аналог, руб.";
            this.analogCosts.Name = "analogCosts";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(48, 274);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(177, 60);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumProj,
            this.sumAnalog});
            this.dataGridView2.Location = new System.Drawing.Point(286, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(502, 69);
            this.dataGridView2.TabIndex = 2;
            // 
            // sumProj
            // 
            this.sumProj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumProj.HeaderText = "Проект";
            this.sumProj.Name = "sumProj";
            // 
            // sumAnalog
            // 
            this.sumAnalog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumAnalog.HeaderText = "Аналог";
            this.sumAnalog.Name = "sumAnalog";
            // 
            // YearCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YearCostsForm";
            this.Text = "YearCostsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn projCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn analogCosts;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumProj;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumAnalog;
    }
}