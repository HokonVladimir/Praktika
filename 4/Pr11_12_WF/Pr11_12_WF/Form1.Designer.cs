namespace Pr11_12_WF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.number_box = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.square_side_box = new System.Windows.Forms.TextBox();
            this.square_side_label = new System.Windows.Forms.Label();
            this.side_box = new System.Windows.Forms.TextBox();
            this.side_label = new System.Windows.Forms.Label();
            this.ToSquare_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sideB_box = new System.Windows.Forms.TextBox();
            this.sideA_box = new System.Windows.Forms.TextBox();
            this.sideB_label = new System.Windows.Forms.Label();
            this.sideA_label = new System.Windows.Forms.Label();
            this.decrement_box = new System.Windows.Forms.TextBox();
            this.increment_box = new System.Windows.Forms.TextBox();
            this.product_box = new System.Windows.Forms.TextBox();
            this.decrement_label = new System.Windows.Forms.Label();
            this.increment_label = new System.Windows.Forms.Label();
            this.product_label = new System.Windows.Forms.Label();
            this.IsSquare_box = new System.Windows.Forms.TextBox();
            this.perimetr_box = new System.Windows.Forms.TextBox();
            this.IsSquare_label = new System.Windows.Forms.Label();
            this.perimetr_label = new System.Windows.Forms.Label();
            this.area_box = new System.Windows.Forms.TextBox();
            this.area_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculate_button);
            this.groupBox1.Controls.Add(this.number_box);
            this.groupBox1.Controls.Add(this.number_label);
            this.groupBox1.Controls.Add(this.square_side_box);
            this.groupBox1.Controls.Add(this.square_side_label);
            this.groupBox1.Controls.Add(this.side_box);
            this.groupBox1.Controls.Add(this.side_label);
            this.groupBox1.Controls.Add(this.ToSquare_button);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(515, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные:";
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(422, 54);
            this.calculate_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(81, 21);
            this.calculate_button.TabIndex = 6;
            this.calculate_button.Text = "Рассчитать";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // number_box
            // 
            this.number_box.Location = new System.Drawing.Point(322, 58);
            this.number_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(76, 20);
            this.number_box.TabIndex = 5;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(4, 61);
            this.number_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(324, 13);
            this.number_label.TabIndex = 4;
            this.number_label.Text = "Число, на которое нужно умножить стороны прямоугольника:";
            // 
            // square_side_box
            // 
            this.square_side_box.Location = new System.Drawing.Point(109, 42);
            this.square_side_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.square_side_box.Name = "square_side_box";
            this.square_side_box.Size = new System.Drawing.Size(76, 20);
            this.square_side_box.TabIndex = 3;
            // 
            // square_side_label
            // 
            this.square_side_label.AutoSize = true;
            this.square_side_label.Location = new System.Drawing.Point(4, 42);
            this.square_side_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.square_side_label.Name = "square_side_label";
            this.square_side_label.Size = new System.Drawing.Size(102, 13);
            this.square_side_label.TabIndex = 2;
            this.square_side_label.Text = "Сторона квадрата:";
            // 
            // side_box
            // 
            this.side_box.Location = new System.Drawing.Point(224, 20);
            this.side_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.side_box.Name = "side_box";
            this.side_box.Size = new System.Drawing.Size(98, 20);
            this.side_box.TabIndex = 1;
            // 
            // side_label
            // 
            this.side_label.AutoSize = true;
            this.side_label.Location = new System.Drawing.Point(4, 22);
            this.side_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.side_label.Name = "side_label";
            this.side_label.Size = new System.Drawing.Size(218, 13);
            this.side_label.TabIndex = 0;
            this.side_label.Text = "Стороны прямоугольника (через пробел):";
            // 
            // ToSquare_button
            // 
            this.ToSquare_button.Location = new System.Drawing.Point(334, 15);
            this.ToSquare_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToSquare_button.Name = "ToSquare_button";
            this.ToSquare_button.Size = new System.Drawing.Size(170, 28);
            this.ToSquare_button.TabIndex = 13;
            this.ToSquare_button.Text = "Преобразовать в квадрат";
            this.ToSquare_button.UseVisualStyleBackColor = true;
            this.ToSquare_button.Click += new System.EventHandler(this.ToSquare_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sideB_box);
            this.groupBox2.Controls.Add(this.sideA_box);
            this.groupBox2.Controls.Add(this.sideB_label);
            this.groupBox2.Controls.Add(this.sideA_label);
            this.groupBox2.Controls.Add(this.decrement_box);
            this.groupBox2.Controls.Add(this.increment_box);
            this.groupBox2.Controls.Add(this.product_box);
            this.groupBox2.Controls.Add(this.decrement_label);
            this.groupBox2.Controls.Add(this.increment_label);
            this.groupBox2.Controls.Add(this.product_label);
            this.groupBox2.Controls.Add(this.IsSquare_box);
            this.groupBox2.Controls.Add(this.perimetr_box);
            this.groupBox2.Controls.Add(this.IsSquare_label);
            this.groupBox2.Controls.Add(this.perimetr_label);
            this.groupBox2.Controls.Add(this.area_box);
            this.groupBox2.Controls.Add(this.area_label);
            this.groupBox2.Location = new System.Drawing.Point(9, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(515, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sideB_box
            // 
            this.sideB_box.Location = new System.Drawing.Point(70, 43);
            this.sideB_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideB_box.Name = "sideB_box";
            this.sideB_box.ReadOnly = true;
            this.sideB_box.Size = new System.Drawing.Size(76, 20);
            this.sideB_box.TabIndex = 23;
            // 
            // sideA_box
            // 
            this.sideA_box.Location = new System.Drawing.Point(70, 17);
            this.sideA_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sideA_box.Name = "sideA_box";
            this.sideA_box.ReadOnly = true;
            this.sideA_box.Size = new System.Drawing.Size(76, 20);
            this.sideA_box.TabIndex = 22;
            // 
            // sideB_label
            // 
            this.sideB_label.AutoSize = true;
            this.sideB_label.Location = new System.Drawing.Point(4, 43);
            this.sideB_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sideB_label.Name = "sideB_label";
            this.sideB_label.Size = new System.Drawing.Size(62, 13);
            this.sideB_label.TabIndex = 21;
            this.sideB_label.Text = "Сторона В:";
            // 
            // sideA_label
            // 
            this.sideA_label.AutoSize = true;
            this.sideA_label.Location = new System.Drawing.Point(4, 17);
            this.sideA_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sideA_label.Name = "sideA_label";
            this.sideA_label.Size = new System.Drawing.Size(62, 13);
            this.sideA_label.TabIndex = 20;
            this.sideA_label.Text = "Сторона А:";
            // 
            // decrement_box
            // 
            this.decrement_box.Location = new System.Drawing.Point(154, 190);
            this.decrement_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decrement_box.Name = "decrement_box";
            this.decrement_box.ReadOnly = true;
            this.decrement_box.Size = new System.Drawing.Size(164, 20);
            this.decrement_box.TabIndex = 19;
            // 
            // increment_box
            // 
            this.increment_box.Location = new System.Drawing.Point(154, 167);
            this.increment_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.increment_box.Name = "increment_box";
            this.increment_box.ReadOnly = true;
            this.increment_box.Size = new System.Drawing.Size(164, 20);
            this.increment_box.TabIndex = 18;
            // 
            // product_box
            // 
            this.product_box.Location = new System.Drawing.Point(154, 144);
            this.product_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_box.Name = "product_box";
            this.product_box.ReadOnly = true;
            this.product_box.Size = new System.Drawing.Size(164, 20);
            this.product_box.TabIndex = 17;
            // 
            // decrement_label
            // 
            this.decrement_label.AutoSize = true;
            this.decrement_label.Location = new System.Drawing.Point(4, 190);
            this.decrement_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.decrement_label.Name = "decrement_label";
            this.decrement_label.Size = new System.Drawing.Size(68, 13);
            this.decrement_label.TabIndex = 16;
            this.decrement_label.Text = "Декремент:";
            // 
            // increment_label
            // 
            this.increment_label.AutoSize = true;
            this.increment_label.Location = new System.Drawing.Point(4, 167);
            this.increment_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.increment_label.Name = "increment_label";
            this.increment_label.Size = new System.Drawing.Size(67, 13);
            this.increment_label.TabIndex = 15;
            this.increment_label.Text = "Инкремент:";
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(4, 144);
            this.product_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(122, 13);
            this.product_label.TabIndex = 14;
            this.product_label.Text = "Результат умножения:";
            // 
            // IsSquare_box
            // 
            this.IsSquare_box.Location = new System.Drawing.Point(154, 116);
            this.IsSquare_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IsSquare_box.Name = "IsSquare_box";
            this.IsSquare_box.ReadOnly = true;
            this.IsSquare_box.Size = new System.Drawing.Size(76, 20);
            this.IsSquare_box.TabIndex = 12;
            // 
            // perimetr_box
            // 
            this.perimetr_box.Location = new System.Drawing.Point(154, 91);
            this.perimetr_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.perimetr_box.Name = "perimetr_box";
            this.perimetr_box.ReadOnly = true;
            this.perimetr_box.Size = new System.Drawing.Size(76, 20);
            this.perimetr_box.TabIndex = 11;
            // 
            // IsSquare_label
            // 
            this.IsSquare_label.AutoSize = true;
            this.IsSquare_label.Location = new System.Drawing.Point(4, 116);
            this.IsSquare_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IsSquare_label.Name = "IsSquare_label";
            this.IsSquare_label.Size = new System.Drawing.Size(135, 13);
            this.IsSquare_label.TabIndex = 10;
            this.IsSquare_label.Text = "Является ли квадратом?";
            // 
            // perimetr_label
            // 
            this.perimetr_label.AutoSize = true;
            this.perimetr_label.Location = new System.Drawing.Point(4, 91);
            this.perimetr_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.perimetr_label.Name = "perimetr_label";
            this.perimetr_label.Size = new System.Drawing.Size(151, 13);
            this.perimetr_label.TabIndex = 9;
            this.perimetr_label.Text = "Периметр прямоугольника: ";
            // 
            // area_box
            // 
            this.area_box.Location = new System.Drawing.Point(154, 62);
            this.area_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.area_box.Name = "area_box";
            this.area_box.ReadOnly = true;
            this.area_box.Size = new System.Drawing.Size(76, 20);
            this.area_box.TabIndex = 8;
            // 
            // area_label
            // 
            this.area_label.AutoSize = true;
            this.area_label.Location = new System.Drawing.Point(4, 64);
            this.area_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.area_label.Name = "area_label";
            this.area_label.Size = new System.Drawing.Size(144, 13);
            this.area_label.TabIndex = 7;
            this.area_label.Text = "Площадь прямоугольника:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Практика 11-12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.TextBox number_box;
		private System.Windows.Forms.Label number_label;
		private System.Windows.Forms.TextBox square_side_box;
		private System.Windows.Forms.Label square_side_label;
		private System.Windows.Forms.TextBox side_box;
		private System.Windows.Forms.Label side_label;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label area_label;
		private System.Windows.Forms.TextBox decrement_box;
		private System.Windows.Forms.TextBox increment_box;
		private System.Windows.Forms.TextBox product_box;
		private System.Windows.Forms.Label decrement_label;
		private System.Windows.Forms.Label increment_label;
		private System.Windows.Forms.Label product_label;
		private System.Windows.Forms.Button ToSquare_button;
		private System.Windows.Forms.TextBox IsSquare_box;
		private System.Windows.Forms.TextBox perimetr_box;
		private System.Windows.Forms.Label IsSquare_label;
		private System.Windows.Forms.Label perimetr_label;
		private System.Windows.Forms.TextBox area_box;
		private System.Windows.Forms.TextBox sideB_box;
		private System.Windows.Forms.TextBox sideA_box;
		private System.Windows.Forms.Label sideB_label;
		private System.Windows.Forms.Label sideA_label;
	}
}

