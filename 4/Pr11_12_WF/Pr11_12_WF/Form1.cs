using System;
using System.Windows.Forms;

namespace Pr11_12_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Rectangle rectangle;
		private void calculate_button_Click(object sender, EventArgs e)
		{
			try
			{
				rectangle = side_box.Text;
				Show_Rezults();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void ToSquare_button_Click(object sender, EventArgs e)
		{
			try
			{
				rectangle.SideA_ = rectangle.SideB_ = Convert.ToInt32(square_side_box.Text);
				Show_Rezults();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		private void Show_Rezults()
		{
			sideA_box.Text = rectangle.SideA_.ToString();
			sideB_box.Text = rectangle.SideB_.ToString();
			area_box.Text = rectangle.area().ToString();
			perimetr_box.Text = rectangle.perimeter().ToString();
			IsSquare_box.Text = rectangle.isSquare.ToString();
			product_box.Text = rectangle * Convert.ToInt32(number_box.Text);
			increment_box.Text = rectangle++;
			rectangle--;
			decrement_box.Text = rectangle--;
			if (rectangle) MessageBox.Show("Фигура является квадратом");
			else MessageBox.Show("Фигура не является квадратом");
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
