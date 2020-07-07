using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Pr9_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void execute1_button_Click(object sender, EventArgs e)
		{
			try
			{
				string str = numbers_box.Text;
				double[] array = new double[str.Trim().Split(' ').Length];
				string[] splitText = str.Trim().Split(' ');
				FileStream f = new FileStream(@"C:\Users\IRU\Desktop\3-4\3\Pr9_1\Pr9_1\bin\Debug\Text.txt", FileMode.Open);
				BinaryWriter fOut = new BinaryWriter(f);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Convert.ToDouble(splitText[i]);
					fOut.Write(array[i]);
				}
				fOut.Close();
				f = new FileStream(@"C:\Users\IRU\Desktop\3-4\3\Pr9_1\Pr9_1\bin\Debug\Text.txt", FileMode.Open);
				BinaryReader fIn = new BinaryReader(f);
				long m = f.Length;
				double max = fIn.ReadDouble();
				for (long i = 8; i < m; i += 16)
				{
					f.Seek(i, SeekOrigin.Begin);
					if (fIn.ReadDouble() > max) max = fIn.ReadDouble();
				}
				max_box.Text = max.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void execute2_button_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> collection = new List<string>();
				using (StreamReader sr = File.OpenText(@"C:\Users\IRU\Desktop\3-4\3\Pr9_2\Pr9_2\bin\Debug\Text.txt"))
					for (int i = 0; i < File.ReadAllLines(@"C:\Users\IRU\Desktop\3-4\3\Pr9_2\Pr9_2\bin\Debug\Text.txt").Length; i++)
					{
						collection.Add(sr.ReadLine());
					}
				int k1 = Convert.ToInt32(begin_box.Text);
				int k2 = Convert.ToInt32(end_box.Text);
				string rezult = "";
				if (k1 < collection.Count && k2 < collection.Count && k1 <= k2)
					for (int i = k1; i <= k2; i++)
						rezult+=collection[i]+"\n";
				else throw new Exception("Некорректный ввод");
				string_label.Text = $"Строки с номерами от {k1} до {k2}:";
				string_box.Text = rezult;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void task1_page_Click(object sender, EventArgs e)
		{

		}
	}
}
