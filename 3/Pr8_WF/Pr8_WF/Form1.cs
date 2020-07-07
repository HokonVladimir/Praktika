using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pr8_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void find_button_Click(object sender, EventArgs e)
		{
			try
			{
				Regex r = new Regex(@"((1\d\d|2([0-4]\d|5[0-5])|\D\d\d?)\.?){4}$");
				string rezult = "";
				string text = text_box.Text;
				if (text == "") throw new Exception("Пустая строка");
				else
				{
					char[] splitters = { ';', ',', ' ', '!', '?', ':' };
					string[] splitText = text.Trim().Split(splitters);
					foreach (string str in splitText)
					{
						if (r.IsMatch(str))
						{
							rezult+=str+"\n";
						}
					}
				}
				IP_box.Text = rezult;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void text_box_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
