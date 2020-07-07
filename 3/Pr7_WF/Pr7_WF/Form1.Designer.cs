namespace Pr7_WF
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
			this.tasks = new System.Windows.Forms.TabControl();
			this.task1_page = new System.Windows.Forms.TabPage();
			this.lastIndex_box = new System.Windows.Forms.TextBox();
			this.firstIndex_box = new System.Windows.Forms.TextBox();
			this.lastIndex_label = new System.Windows.Forms.Label();
			this.firstIndex_label = new System.Windows.Forms.Label();
			this.execute_button = new System.Windows.Forms.Button();
			this.symbol_box = new System.Windows.Forms.TextBox();
			this.symbol_label = new System.Windows.Forms.Label();
			this.string_label = new System.Windows.Forms.Label();
			this.string_box = new System.Windows.Forms.TextBox();
			this.task2_page = new System.Windows.Forms.TabPage();
			this.words_label = new System.Windows.Forms.Label();
			this.text_box = new System.Windows.Forms.RichTextBox();
			this.text_label = new System.Windows.Forms.Label();
			this.run_button = new System.Windows.Forms.Button();
			this.words_box = new System.Windows.Forms.RichTextBox();
			this.tasks.SuspendLayout();
			this.task1_page.SuspendLayout();
			this.task2_page.SuspendLayout();
			this.SuspendLayout();
			// 
			// tasks
			// 
			this.tasks.Controls.Add(this.task1_page);
			this.tasks.Controls.Add(this.task2_page);
			this.tasks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tasks.Location = new System.Drawing.Point(0, 0);
			this.tasks.Name = "tasks";
			this.tasks.SelectedIndex = 0;
			this.tasks.Size = new System.Drawing.Size(581, 192);
			this.tasks.TabIndex = 0;
			// 
			// task1_page
			// 
			this.task1_page.Controls.Add(this.lastIndex_box);
			this.task1_page.Controls.Add(this.firstIndex_box);
			this.task1_page.Controls.Add(this.lastIndex_label);
			this.task1_page.Controls.Add(this.firstIndex_label);
			this.task1_page.Controls.Add(this.execute_button);
			this.task1_page.Controls.Add(this.symbol_box);
			this.task1_page.Controls.Add(this.symbol_label);
			this.task1_page.Controls.Add(this.string_label);
			this.task1_page.Controls.Add(this.string_box);
			this.task1_page.Location = new System.Drawing.Point(4, 25);
			this.task1_page.Name = "task1_page";
			this.task1_page.Padding = new System.Windows.Forms.Padding(3);
			this.task1_page.Size = new System.Drawing.Size(573, 163);
			this.task1_page.TabIndex = 0;
			this.task1_page.Text = "Задание 1";
			this.task1_page.UseVisualStyleBackColor = true;
			// 
			// lastIndex_box
			// 
			this.lastIndex_box.Location = new System.Drawing.Point(445, 116);
			this.lastIndex_box.Name = "lastIndex_box";
			this.lastIndex_box.ReadOnly = true;
			this.lastIndex_box.Size = new System.Drawing.Size(100, 22);
			this.lastIndex_box.TabIndex = 8;
			// 
			// firstIndex_box
			// 
			this.firstIndex_box.Location = new System.Drawing.Point(445, 84);
			this.firstIndex_box.Name = "firstIndex_box";
			this.firstIndex_box.ReadOnly = true;
			this.firstIndex_box.Size = new System.Drawing.Size(100, 22);
			this.firstIndex_box.TabIndex = 7;
			// 
			// lastIndex_label
			// 
			this.lastIndex_label.AutoSize = true;
			this.lastIndex_label.Location = new System.Drawing.Point(9, 116);
			this.lastIndex_label.Name = "lastIndex_label";
			this.lastIndex_label.Size = new System.Drawing.Size(415, 17);
			this.lastIndex_label.TabIndex = 6;
			this.lastIndex_label.Text = "Порядковый номер последнего вхождения символа в строку: ";
			// 
			// firstIndex_label
			// 
			this.firstIndex_label.AutoSize = true;
			this.firstIndex_label.Location = new System.Drawing.Point(9, 87);
			this.firstIndex_label.Name = "firstIndex_label";
			this.firstIndex_label.Size = new System.Drawing.Size(391, 17);
			this.firstIndex_label.TabIndex = 5;
			this.firstIndex_label.Text = "Порядковый номер первого вхождения символа в строку: ";
			// 
			// execute_button
			// 
			this.execute_button.Location = new System.Drawing.Point(257, 39);
			this.execute_button.Name = "execute_button";
			this.execute_button.Size = new System.Drawing.Size(103, 38);
			this.execute_button.TabIndex = 4;
			this.execute_button.Text = "Выполнить";
			this.execute_button.UseVisualStyleBackColor = true;
			this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
			// 
			// symbol_box
			// 
			this.symbol_box.Location = new System.Drawing.Point(133, 46);
			this.symbol_box.Name = "symbol_box";
			this.symbol_box.Size = new System.Drawing.Size(100, 22);
			this.symbol_box.TabIndex = 3;
			// 
			// symbol_label
			// 
			this.symbol_label.AutoSize = true;
			this.symbol_label.Location = new System.Drawing.Point(9, 49);
			this.symbol_label.Name = "symbol_label";
			this.symbol_label.Size = new System.Drawing.Size(118, 17);
			this.symbol_label.TabIndex = 2;
			this.symbol_label.Text = "Введите символ:";
			// 
			// string_label
			// 
			this.string_label.AutoSize = true;
			this.string_label.Location = new System.Drawing.Point(8, 11);
			this.string_label.Name = "string_label";
			this.string_label.Size = new System.Drawing.Size(119, 17);
			this.string_label.TabIndex = 1;
			this.string_label.Text = "Введите строку: ";
			// 
			// string_box
			// 
			this.string_box.Location = new System.Drawing.Point(133, 11);
			this.string_box.Name = "string_box";
			this.string_box.Size = new System.Drawing.Size(412, 22);
			this.string_box.TabIndex = 0;
			// 
			// task2_page
			// 
			this.task2_page.Controls.Add(this.words_box);
			this.task2_page.Controls.Add(this.run_button);
			this.task2_page.Controls.Add(this.words_label);
			this.task2_page.Controls.Add(this.text_box);
			this.task2_page.Controls.Add(this.text_label);
			this.task2_page.Location = new System.Drawing.Point(4, 25);
			this.task2_page.Name = "task2_page";
			this.task2_page.Padding = new System.Windows.Forms.Padding(3);
			this.task2_page.Size = new System.Drawing.Size(573, 163);
			this.task2_page.TabIndex = 1;
			this.task2_page.Text = "Задание 2";
			this.task2_page.UseVisualStyleBackColor = true;
			// 
			// words_label
			// 
			this.words_label.AutoSize = true;
			this.words_label.Location = new System.Drawing.Point(331, 8);
			this.words_label.Name = "words_label";
			this.words_label.Size = new System.Drawing.Size(222, 17);
			this.words_label.TabIndex = 2;
			this.words_label.Text = "Самые короткие слова в тексте:";
			// 
			// text_box
			// 
			this.text_box.Location = new System.Drawing.Point(68, 5);
			this.text_box.Name = "text_box";
			this.text_box.Size = new System.Drawing.Size(257, 118);
			this.text_box.TabIndex = 1;
			this.text_box.Text = "";
			// 
			// text_label
			// 
			this.text_label.AutoSize = true;
			this.text_label.Location = new System.Drawing.Point(8, 8);
			this.text_label.Name = "text_label";
			this.text_label.Size = new System.Drawing.Size(54, 17);
			this.text_label.TabIndex = 0;
			this.text_label.Text = "Текст: ";
			// 
			// run_button
			// 
			this.run_button.Location = new System.Drawing.Point(11, 129);
			this.run_button.Name = "run_button";
			this.run_button.Size = new System.Drawing.Size(110, 28);
			this.run_button.TabIndex = 4;
			this.run_button.Text = "Выполнить";
			this.run_button.UseVisualStyleBackColor = true;
			this.run_button.Click += new System.EventHandler(this.run_button_Click);
			// 
			// words_box
			// 
			this.words_box.Location = new System.Drawing.Point(334, 28);
			this.words_box.Name = "words_box";
			this.words_box.Size = new System.Drawing.Size(231, 129);
			this.words_box.TabIndex = 5;
			this.words_box.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 192);
			this.Controls.Add(this.tasks);
			this.Name = "Form1";
			this.Text = "Практика 7";
			this.tasks.ResumeLayout(false);
			this.task1_page.ResumeLayout(false);
			this.task1_page.PerformLayout();
			this.task2_page.ResumeLayout(false);
			this.task2_page.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tasks;
		private System.Windows.Forms.TabPage task1_page;
		private System.Windows.Forms.TextBox lastIndex_box;
		private System.Windows.Forms.TextBox firstIndex_box;
		private System.Windows.Forms.Label lastIndex_label;
		private System.Windows.Forms.Label firstIndex_label;
		private System.Windows.Forms.Button execute_button;
		private System.Windows.Forms.TextBox symbol_box;
		private System.Windows.Forms.Label symbol_label;
		private System.Windows.Forms.Label string_label;
		private System.Windows.Forms.TextBox string_box;
		private System.Windows.Forms.TabPage task2_page;
		private System.Windows.Forms.Label words_label;
		private System.Windows.Forms.RichTextBox text_box;
		private System.Windows.Forms.Label text_label;
		private System.Windows.Forms.RichTextBox words_box;
		private System.Windows.Forms.Button run_button;
	}
}

