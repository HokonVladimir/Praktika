namespace Pr4_1_2_WF
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
			this.task2_page = new System.Windows.Forms.TabPage();
			this.a_label = new System.Windows.Forms.Label();
			this.a_box = new System.Windows.Forms.TextBox();
			this.b_label = new System.Windows.Forms.Label();
			this.b_box = new System.Windows.Forms.TextBox();
			this.calculate_button = new System.Windows.Forms.Button();
			this.NOD_label = new System.Windows.Forms.Label();
			this.NOD_box = new System.Windows.Forms.TextBox();
			this.N_label = new System.Windows.Forms.Label();
			this.N_box = new System.Windows.Forms.TextBox();
			this.figure_box = new System.Windows.Forms.RichTextBox();
			this.execute_button = new System.Windows.Forms.Button();
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
			this.tasks.Size = new System.Drawing.Size(369, 228);
			this.tasks.TabIndex = 0;
			// 
			// task1_page
			// 
			this.task1_page.Controls.Add(this.NOD_box);
			this.task1_page.Controls.Add(this.NOD_label);
			this.task1_page.Controls.Add(this.calculate_button);
			this.task1_page.Controls.Add(this.b_box);
			this.task1_page.Controls.Add(this.b_label);
			this.task1_page.Controls.Add(this.a_box);
			this.task1_page.Controls.Add(this.a_label);
			this.task1_page.Location = new System.Drawing.Point(4, 25);
			this.task1_page.Name = "task1_page";
			this.task1_page.Padding = new System.Windows.Forms.Padding(3);
			this.task1_page.Size = new System.Drawing.Size(361, 199);
			this.task1_page.TabIndex = 0;
			this.task1_page.Text = "Задание 1";
			this.task1_page.UseVisualStyleBackColor = true;
			// 
			// task2_page
			// 
			this.task2_page.Controls.Add(this.execute_button);
			this.task2_page.Controls.Add(this.figure_box);
			this.task2_page.Controls.Add(this.N_box);
			this.task2_page.Controls.Add(this.N_label);
			this.task2_page.Location = new System.Drawing.Point(4, 25);
			this.task2_page.Name = "task2_page";
			this.task2_page.Padding = new System.Windows.Forms.Padding(3);
			this.task2_page.Size = new System.Drawing.Size(361, 199);
			this.task2_page.TabIndex = 1;
			this.task2_page.Text = "Задание 2";
			this.task2_page.UseVisualStyleBackColor = true;
			// 
			// a_label
			// 
			this.a_label.AutoSize = true;
			this.a_label.Location = new System.Drawing.Point(18, 26);
			this.a_label.Name = "a_label";
			this.a_label.Size = new System.Drawing.Size(65, 17);
			this.a_label.TabIndex = 1;
			this.a_label.Text = "Число a:";
			// 
			// a_box
			// 
			this.a_box.Location = new System.Drawing.Point(89, 23);
			this.a_box.Name = "a_box";
			this.a_box.Size = new System.Drawing.Size(100, 22);
			this.a_box.TabIndex = 2;
			// 
			// b_label
			// 
			this.b_label.AutoSize = true;
			this.b_label.Location = new System.Drawing.Point(18, 61);
			this.b_label.Name = "b_label";
			this.b_label.Size = new System.Drawing.Size(65, 17);
			this.b_label.TabIndex = 3;
			this.b_label.Text = "Число b:";
			// 
			// b_box
			// 
			this.b_box.Location = new System.Drawing.Point(89, 58);
			this.b_box.Name = "b_box";
			this.b_box.Size = new System.Drawing.Size(100, 22);
			this.b_box.TabIndex = 4;
			// 
			// calculate_button
			// 
			this.calculate_button.Location = new System.Drawing.Point(21, 102);
			this.calculate_button.Name = "calculate_button";
			this.calculate_button.Size = new System.Drawing.Size(121, 34);
			this.calculate_button.TabIndex = 5;
			this.calculate_button.Text = "Рассчитать";
			this.calculate_button.UseVisualStyleBackColor = true;
			this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
			// 
			// NOD_label
			// 
			this.NOD_label.AutoSize = true;
			this.NOD_label.Location = new System.Drawing.Point(195, 42);
			this.NOD_label.Name = "NOD_label";
			this.NOD_label.Size = new System.Drawing.Size(44, 17);
			this.NOD_label.TabIndex = 6;
			this.NOD_label.Text = "НОД:";
			// 
			// NOD_box
			// 
			this.NOD_box.Location = new System.Drawing.Point(245, 39);
			this.NOD_box.Name = "NOD_box";
			this.NOD_box.ReadOnly = true;
			this.NOD_box.Size = new System.Drawing.Size(100, 22);
			this.NOD_box.TabIndex = 7;
			// 
			// N_label
			// 
			this.N_label.AutoSize = true;
			this.N_label.Location = new System.Drawing.Point(8, 13);
			this.N_label.Name = "N_label";
			this.N_label.Size = new System.Drawing.Size(26, 17);
			this.N_label.TabIndex = 0;
			this.N_label.Text = "N: ";
			// 
			// N_box
			// 
			this.N_box.Location = new System.Drawing.Point(40, 13);
			this.N_box.Name = "N_box";
			this.N_box.Size = new System.Drawing.Size(100, 22);
			this.N_box.TabIndex = 1;
			// 
			// figure_box
			// 
			this.figure_box.Location = new System.Drawing.Point(11, 51);
			this.figure_box.Name = "figure_box";
			this.figure_box.ReadOnly = true;
			this.figure_box.Size = new System.Drawing.Size(129, 137);
			this.figure_box.TabIndex = 2;
			this.figure_box.Text = "";
			// 
			// execute_button
			// 
			this.execute_button.Location = new System.Drawing.Point(168, 8);
			this.execute_button.Name = "execute_button";
			this.execute_button.Size = new System.Drawing.Size(95, 33);
			this.execute_button.TabIndex = 3;
			this.execute_button.Text = "Выполнить";
			this.execute_button.UseVisualStyleBackColor = true;
			this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 228);
			this.Controls.Add(this.tasks);
			this.Name = "Form1";
			this.Text = "Практика 4";
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
		private System.Windows.Forms.TextBox NOD_box;
		private System.Windows.Forms.Label NOD_label;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.TextBox b_box;
		private System.Windows.Forms.Label b_label;
		private System.Windows.Forms.TextBox a_box;
		private System.Windows.Forms.Label a_label;
		private System.Windows.Forms.TabPage task2_page;
		private System.Windows.Forms.TextBox N_box;
		private System.Windows.Forms.Label N_label;
		private System.Windows.Forms.RichTextBox figure_box;
		private System.Windows.Forms.Button execute_button;
	}
}

