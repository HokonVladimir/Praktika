namespace Pr9_WF
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
            this.numbers_label = new System.Windows.Forms.Label();
            this.numbers_box = new System.Windows.Forms.TextBox();
            this.max_label = new System.Windows.Forms.Label();
            this.max_box = new System.Windows.Forms.TextBox();
            this.execute1_button = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.TabControl();
            this.task1_page = new System.Windows.Forms.TabPage();
            this.task2_page = new System.Windows.Forms.TabPage();
            this.execute2_button = new System.Windows.Forms.Button();
            this.string_label = new System.Windows.Forms.Label();
            this.string_box = new System.Windows.Forms.RichTextBox();
            this.end_box = new System.Windows.Forms.TextBox();
            this.begin_box = new System.Windows.Forms.TextBox();
            this.end_label = new System.Windows.Forms.Label();
            this.begin_label = new System.Windows.Forms.Label();
            this.tasks.SuspendLayout();
            this.task1_page.SuspendLayout();
            this.task2_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbers_label
            // 
            this.numbers_label.AutoSize = true;
            this.numbers_label.Location = new System.Drawing.Point(4, 2);
            this.numbers_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numbers_label.Name = "numbers_label";
            this.numbers_label.Size = new System.Drawing.Size(210, 13);
            this.numbers_label.TabIndex = 0;
            this.numbers_label.Text = "Введите числа (в строку через пробел): ";
            // 
            // numbers_box
            // 
            this.numbers_box.Location = new System.Drawing.Point(218, 2);
            this.numbers_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numbers_box.Name = "numbers_box";
            this.numbers_box.Size = new System.Drawing.Size(237, 20);
            this.numbers_box.TabIndex = 1;
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(4, 28);
            this.max_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(140, 13);
            this.max_label.TabIndex = 2;
            this.max_label.Text = "Максимальное значение: ";
            // 
            // max_box
            // 
            this.max_box.Location = new System.Drawing.Point(144, 26);
            this.max_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.max_box.Name = "max_box";
            this.max_box.Size = new System.Drawing.Size(76, 20);
            this.max_box.TabIndex = 3;
            // 
            // execute1_button
            // 
            this.execute1_button.Location = new System.Drawing.Point(4, 53);
            this.execute1_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.execute1_button.Name = "execute1_button";
            this.execute1_button.Size = new System.Drawing.Size(92, 26);
            this.execute1_button.TabIndex = 4;
            this.execute1_button.Text = "Выполнить";
            this.execute1_button.UseVisualStyleBackColor = true;
            this.execute1_button.Click += new System.EventHandler(this.execute1_button_Click);
            // 
            // tasks
            // 
            this.tasks.Controls.Add(this.task1_page);
            this.tasks.Controls.Add(this.task2_page);
            this.tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasks.Location = new System.Drawing.Point(0, 0);
            this.tasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tasks.Name = "tasks";
            this.tasks.SelectedIndex = 0;
            this.tasks.Size = new System.Drawing.Size(521, 114);
            this.tasks.TabIndex = 5;
            // 
            // task1_page
            // 
            this.task1_page.Controls.Add(this.numbers_label);
            this.task1_page.Controls.Add(this.execute1_button);
            this.task1_page.Controls.Add(this.numbers_box);
            this.task1_page.Controls.Add(this.max_box);
            this.task1_page.Controls.Add(this.max_label);
            this.task1_page.Location = new System.Drawing.Point(4, 22);
            this.task1_page.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task1_page.Name = "task1_page";
            this.task1_page.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task1_page.Size = new System.Drawing.Size(513, 88);
            this.task1_page.TabIndex = 0;
            this.task1_page.Text = "Задание 1";
            this.task1_page.UseVisualStyleBackColor = true;
            this.task1_page.Click += new System.EventHandler(this.task1_page_Click);
            // 
            // task2_page
            // 
            this.task2_page.Controls.Add(this.execute2_button);
            this.task2_page.Controls.Add(this.string_label);
            this.task2_page.Controls.Add(this.string_box);
            this.task2_page.Controls.Add(this.end_box);
            this.task2_page.Controls.Add(this.begin_box);
            this.task2_page.Controls.Add(this.end_label);
            this.task2_page.Controls.Add(this.begin_label);
            this.task2_page.Location = new System.Drawing.Point(4, 22);
            this.task2_page.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task2_page.Name = "task2_page";
            this.task2_page.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task2_page.Size = new System.Drawing.Size(513, 88);
            this.task2_page.TabIndex = 1;
            this.task2_page.Text = "Задание 2";
            this.task2_page.UseVisualStyleBackColor = true;
            // 
            // execute2_button
            // 
            this.execute2_button.Location = new System.Drawing.Point(61, 65);
            this.execute2_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.execute2_button.Name = "execute2_button";
            this.execute2_button.Size = new System.Drawing.Size(105, 19);
            this.execute2_button.TabIndex = 6;
            this.execute2_button.Text = "Выполнить";
            this.execute2_button.UseVisualStyleBackColor = true;
            this.execute2_button.Click += new System.EventHandler(this.execute2_button_Click);
            // 
            // string_label
            // 
            this.string_label.AutoSize = true;
            this.string_label.Location = new System.Drawing.Point(230, 9);
            this.string_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.string_label.Name = "string_label";
            this.string_label.Size = new System.Drawing.Size(62, 13);
            this.string_label.TabIndex = 5;
            this.string_label.Text = "Результат:";
            // 
            // string_box
            // 
            this.string_box.Location = new System.Drawing.Point(232, 28);
            this.string_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.string_box.Name = "string_box";
            this.string_box.Size = new System.Drawing.Size(278, 56);
            this.string_box.TabIndex = 4;
            this.string_box.Text = "";
            // 
            // end_box
            // 
            this.end_box.Location = new System.Drawing.Point(145, 31);
            this.end_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.end_box.Name = "end_box";
            this.end_box.Size = new System.Drawing.Size(76, 20);
            this.end_box.TabIndex = 3;
            // 
            // begin_box
            // 
            this.begin_box.Location = new System.Drawing.Point(145, 6);
            this.begin_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.begin_box.Name = "begin_box";
            this.begin_box.Size = new System.Drawing.Size(76, 20);
            this.begin_box.TabIndex = 2;
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(6, 31);
            this.end_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(139, 13);
            this.end_label.TabIndex = 1;
            this.end_label.Text = "Номер последней строки:";
            // 
            // begin_label
            // 
            this.begin_label.AutoSize = true;
            this.begin_label.Location = new System.Drawing.Point(6, 6);
            this.begin_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.begin_label.Name = "begin_label";
            this.begin_label.Size = new System.Drawing.Size(138, 13);
            this.begin_label.TabIndex = 0;
            this.begin_label.Text = "Номер начальной строки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 114);
            this.Controls.Add(this.tasks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Практика 9";
            this.tasks.ResumeLayout(false);
            this.task1_page.ResumeLayout(false);
            this.task1_page.PerformLayout();
            this.task2_page.ResumeLayout(false);
            this.task2_page.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label numbers_label;
		private System.Windows.Forms.TextBox numbers_box;
		private System.Windows.Forms.Label max_label;
		private System.Windows.Forms.TextBox max_box;
		private System.Windows.Forms.Button execute1_button;
		private System.Windows.Forms.TabControl tasks;
		private System.Windows.Forms.TabPage task1_page;
		private System.Windows.Forms.TabPage task2_page;
		private System.Windows.Forms.Button execute2_button;
		private System.Windows.Forms.Label string_label;
		private System.Windows.Forms.RichTextBox string_box;
		private System.Windows.Forms.TextBox end_box;
		private System.Windows.Forms.TextBox begin_box;
		private System.Windows.Forms.Label end_label;
		private System.Windows.Forms.Label begin_label;
	}
}

