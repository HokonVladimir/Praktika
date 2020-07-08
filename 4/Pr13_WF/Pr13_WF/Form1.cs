using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pr13_WF
{
	public partial class Form1 : Form
	{
		List<Edition> editions_list = new List<Edition>();
		private void fill_tabel(DataGridView tabel, List<Edition> list)
		{
			tabel.RowCount = list.Count;
			for (int i = 0; i < tabel.RowCount; i++)
			{
				list[i].info(tabel.Rows[i]);
			}
		}
		public Form1()
		{
			InitializeComponent();
			try
			{
				string path = @"Edition.txt";
				string[] all_jlines = File.ReadAllLines(path);
				for (int i = 0; i < all_jlines.Length; i++)
				{
					string[] position = all_jlines[i].Split(';');
					if (position.Length == 4)
					{
						if (char.IsDigit(position[2][0]))
						{
							Book book = new Book(position[0], position[1], position[2], position[3]);
							editions_list.Add(book);
						}
						else
						{
							Electronic_resource electronic_resource = new Electronic_resource(position[0], position[1], position[2], position[3]);
							editions_list.Add(electronic_resource);
						}
					}
					else
					{
						if (position.Length == 5)
						{
							Article article = new Article(position[0], position[1], position[2], position[3], position[4]);
							editions_list.Add(article);
						}
						else throw new Exception("Некорректная считаная строка");
					}
					fill_tabel(Edition_tabel, editions_list);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void find_button_Click(object sender, EventArgs e)
		{
			List<Edition> find_position = new List<Edition>();
			string Lastname = search_box.Text;
			foreach (Edition position in editions_list)
			{
				if (position.is_required(Lastname)) find_position.Add(position);
			}
			if (find_position.Count == 0) MessageBox.Show("Нет записей, удовлетворяющих условию поиска");
			else fill_tabel(Edition_tabel, find_position);
		}

		private void cansel_button_Click(object sender, EventArgs e)
		{
			fill_tabel(Edition_tabel, editions_list);
			search_box.Clear();
		}

		private void Edition_tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
