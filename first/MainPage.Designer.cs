namespace first
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Arxiv = new System.Windows.Forms.Button();
            this.Chose = new System.Windows.Forms.Button();
            this.AddArxiv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sort = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.AddIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Detail
            // 
            this.Detail.Location = new System.Drawing.Point(13, 34);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(200, 46);
            this.Detail.TabIndex = 0;
            this.Detail.Text = "Детальніше";
            this.Detail.UseVisualStyleBackColor = true;
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(13, 96);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 44);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Додати злочинця";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 161);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(200, 44);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Редагувати";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Arxiv
            // 
            this.Arxiv.Location = new System.Drawing.Point(663, 548);
            this.Arxiv.Name = "Arxiv";
            this.Arxiv.Size = new System.Drawing.Size(334, 63);
            this.Arxiv.TabIndex = 2;
            this.Arxiv.Text = "Архів";
            this.Arxiv.UseVisualStyleBackColor = true;
            this.Arxiv.Click += new System.EventHandler(this.Arxiv_Click);
            // 
            // Chose
            // 
            this.Chose.Location = new System.Drawing.Point(1052, 548);
            this.Chose.Name = "Chose";
            this.Chose.Size = new System.Drawing.Size(295, 63);
            this.Chose.TabIndex = 5;
            this.Chose.Text = "Зберегти вибірку";
            this.Chose.UseVisualStyleBackColor = true;
            this.Chose.Click += new System.EventHandler(this.Chose_Click);
            // 
            // AddArxiv
            // 
            this.AddArxiv.Location = new System.Drawing.Point(13, 262);
            this.AddArxiv.Name = "AddArxiv";
            this.AddArxiv.Size = new System.Drawing.Size(200, 44);
            this.AddArxiv.TabIndex = 7;
            this.AddArxiv.Text = "Додати в архів";
            this.AddArxiv.UseVisualStyleBackColor = true;
            this.AddArxiv.Click += new System.EventHandler(this.AddArxiv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(233, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 508);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Призвіще";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ім\'я";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Громадянство";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата народження";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Останнє місце проживання";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Остання справа";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Срок дії покарання";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(13, 496);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(200, 46);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Оновити";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(13, 423);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(200, 46);
            this.sort.TabIndex = 10;
            this.sort.Text = "Відсортувати";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(233, 548);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(369, 63);
            this.find.TabIndex = 11;
            this.find.Text = "Пошук за критеріями";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // AddIn
            // 
            this.AddIn.Location = new System.Drawing.Point(13, 326);
            this.AddIn.Name = "AddIn";
            this.AddIn.Size = new System.Drawing.Size(200, 46);
            this.AddIn.TabIndex = 12;
            this.AddIn.Text = "Додати у вибірку";
            this.AddIn.UseVisualStyleBackColor = true;
            this.AddIn.Click += new System.EventHandler(this.AddIn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1552, 726);
            this.Controls.Add(this.AddIn);
            this.Controls.Add(this.find);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddArxiv);
            this.Controls.Add(this.Chose);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Arxiv);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Detail);
            this.Name = "MainPage";
            this.Text = "Картотека інтерполу";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button AddArxiv;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddIn;
        private System.Windows.Forms.Button Arxiv;
        private System.Windows.Forms.Button Chose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Detail;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button sort;

        #endregion
    }
}

