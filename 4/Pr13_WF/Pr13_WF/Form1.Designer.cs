namespace Pr13_WF
{
	partial class Form1
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.Edition_tabel = new System.Windows.Forms.DataGridView();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Journal_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annotation_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_box = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.cansel_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Edition_tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // Edition_tabel
            // 
            this.Edition_tabel.AllowUserToAddRows = false;
            this.Edition_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edition_tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_column,
            this.Autor_column,
            this.Year_column,
            this.Publisher_column,
            this.Journal_column,
            this.Number_column,
            this.Link_column,
            this.Annotation_column});
            this.Edition_tabel.Location = new System.Drawing.Point(7, 56);
            this.Edition_tabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edition_tabel.Name = "Edition_tabel";
            this.Edition_tabel.RowTemplate.Height = 24;
            this.Edition_tabel.Size = new System.Drawing.Size(714, 251);
            this.Edition_tabel.TabIndex = 0;
            this.Edition_tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Edition_tabel_CellContentClick);
            // 
            // Name_column
            // 
            this.Name_column.HeaderText = "Название";
            this.Name_column.Name = "Name_column";
            // 
            // Autor_column
            // 
            this.Autor_column.HeaderText = "Фамилия автора";
            this.Autor_column.Name = "Autor_column";
            // 
            // Year_column
            // 
            this.Year_column.HeaderText = "Год издания";
            this.Year_column.Name = "Year_column";
            // 
            // Publisher_column
            // 
            this.Publisher_column.HeaderText = "Издатель";
            this.Publisher_column.Name = "Publisher_column";
            // 
            // Journal_column
            // 
            this.Journal_column.HeaderText = "Название журнала";
            this.Journal_column.Name = "Journal_column";
            // 
            // Number_column
            // 
            this.Number_column.HeaderText = "Номер журнала";
            this.Number_column.Name = "Number_column";
            // 
            // Link_column
            // 
            this.Link_column.HeaderText = "Ссылка на ресурс";
            this.Link_column.Name = "Link_column";
            // 
            // Annotation_column
            // 
            this.Annotation_column.HeaderText = "Аннотация";
            this.Annotation_column.Name = "Annotation_column";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(9, 28);
            this.search_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(213, 20);
            this.search_box.TabIndex = 1;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(226, 22);
            this.find_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(82, 29);
            this.find_button.TabIndex = 2;
            this.find_button.Text = "Найти";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // cansel_button
            // 
            this.cansel_button.Location = new System.Drawing.Point(313, 22);
            this.cansel_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cansel_button.Name = "cansel_button";
            this.cansel_button.Size = new System.Drawing.Size(82, 29);
            this.cansel_button.TabIndex = 3;
            this.cansel_button.Text = "Сбросить";
            this.cansel_button.UseVisualStyleBackColor = true;
            this.cansel_button.Click += new System.EventHandler(this.cansel_button_Click);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(9, 7);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(141, 13);
            this.search_label.TabIndex = 4;
            this.search_label.Text = "Введите фамилию автора:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 321);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.cansel_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.Edition_tabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Практика 13";
            ((System.ComponentModel.ISupportInitialize)(this.Edition_tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView Edition_tabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Autor_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Year_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Journal_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Link_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Annotation_column;
		private System.Windows.Forms.TextBox search_box;
		private System.Windows.Forms.Button find_button;
		private System.Windows.Forms.Button cansel_button;
		private System.Windows.Forms.Label search_label;
	}
}

