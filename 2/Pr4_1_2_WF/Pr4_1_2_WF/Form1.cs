using System;
using System.Windows.Forms;

namespace Pr4_1_2_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private uint Evklid(uint a, uint b)
		{
			if (a == b) return a;
			else
			{
				if (a > b) return Evklid(a - b, b);
				else return Evklid(a, b - a);
			}
		}
		private void calculate_button_Click(object sender, EventArgs e)
		{
			try
			{
				uint a = Convert.ToUInt32(a_box.Text);
				uint b = Convert.ToUInt32(b_box.Text);
				if (a <= 0 || b <= 0) throw new Exception("Введите целые, неотрицательные числа!");
				else
					NOD_box.Text = Evklid(a, b).ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private int buf;
		private string rez;
		private void print(int N, int symbols = 1)
		{
			for (int i = 0; i < symbols; i++)
				rez+='*';
			for (int i = 0; i < N; i++)
				rez+=' ';
			for (int i = 0; i < symbols; i++)
				rez+='*';
			rez += "\n";
			if (N > 0)
				print(N - 2, ++symbols);
			for (int i = 0; i < symbols - 1; i++)
				rez += '*';
			for (int i = 0; i < N; i++)
				rez += ' ';
			for (int i = 0; i < symbols - 1; i++)
				rez += '*';
			rez += "\n";
		}
		private void execute_button_Click(object sender, EventArgs e)
		{
			try
			{
				buf = Convert.ToInt32(N_box.Text);
				print(buf);
				figure_box.Text = rez;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
