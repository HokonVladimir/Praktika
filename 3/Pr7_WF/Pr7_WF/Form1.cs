using System;
using System.Windows.Forms;

namespace Pr7_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void execute_button_Click(object sender, EventArgs e)
		{
			try
			{
				string str = string_box.Text;
				char symbol = Convert.ToChar(symbol_box.Text);
				if (str.IndexOf(symbol) == -1 || str.LastIndexOf(symbol) == -1) throw new Exception("В строке нет заданного символа");
				else
				{
					firstIndex_box.Text =  (str.IndexOf(symbol) + 1).ToString();
					lastIndex_box.Text =  (str.LastIndexOf(symbol) + 1).ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void run_button_Click(object sender, EventArgs e)
		{
			try
			{
				string message = text_box.Text;
				int min = message.Length;
				char[] splitters = { ' ', ',', '.', '?', '!', ':', ';' };
				string[] array = message.Trim().Split(splitters);
				foreach (string word in array)
				{
					if (word.Length < min) min = word.Length;
				}
				string rezult = "";
				foreach (string word in array)
				{
					if (word.Length == min) rezult+=word+"\n";
				}
				words_box.Text = rezult;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
