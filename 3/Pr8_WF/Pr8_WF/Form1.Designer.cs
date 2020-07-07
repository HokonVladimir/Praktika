namespace Pr8_WF
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
            this.text_label = new System.Windows.Forms.Label();
            this.text_box = new System.Windows.Forms.RichTextBox();
            this.IP_box = new System.Windows.Forms.RichTextBox();
            this.ip_label = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(9, 15);
            this.text_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(43, 13);
            this.text_label.TabIndex = 0;
            this.text_label.Text = "Текст: ";
            // 
            // text_box
            // 
            this.text_box.Location = new System.Drawing.Point(54, 10);
            this.text_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(150, 99);
            this.text_box.TabIndex = 1;
            this.text_box.Text = "";
            this.text_box.TextChanged += new System.EventHandler(this.text_box_TextChanged);
            // 
            // IP_box
            // 
            this.IP_box.Location = new System.Drawing.Point(216, 26);
            this.IP_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IP_box.Name = "IP_box";
            this.IP_box.Size = new System.Drawing.Size(156, 109);
            this.IP_box.TabIndex = 2;
            this.IP_box.Text = "";
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(214, 10);
            this.ip_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(188, 13);
            this.ip_label.TabIndex = 3;
            this.ip_label.Text = "IP-адреса, содержащиеся в тексте:";
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(54, 113);
            this.find_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(149, 21);
            this.find_button.TabIndex = 4;
            this.find_button.Text = "Найти IP-aдреса";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 147);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.IP_box);
            this.Controls.Add(this.text_box);
            this.Controls.Add(this.text_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Практика 8";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label text_label;
		private System.Windows.Forms.RichTextBox text_box;
		private System.Windows.Forms.RichTextBox IP_box;
		private System.Windows.Forms.Label ip_label;
		private System.Windows.Forms.Button find_button;
	}
}

