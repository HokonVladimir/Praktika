using System;
using System.Windows.Forms;

namespace Pr5_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private double function(double x)
		{
			if (x <= -0.2) throw new Exception();
			else return Math.Log(x - 2) / Math.Sqrt(5 * x - 1);
		}
		private void calculate2_Click(object sender, EventArgs e)
		{
			try
			{
				double a = Convert.ToDouble(border1.Text);
				double b = Convert.ToDouble(border2.Text);
				double h = Convert.ToDouble(step.Text);
				string rez = "";
				if (h <= 0) throw new Exception("Некорректное значение шага");
				else
				{
					for (double i = a; i <= b; i += h)
					{
						try
						{
							rez+=$"y({i}) = {function(i)};\n";
						}
						catch
						{
							rez+=$"y({i}) = error;\n";
						}
					}
					tabel.Text = rez;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
