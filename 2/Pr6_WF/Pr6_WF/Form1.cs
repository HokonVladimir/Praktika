using System;
using System.Windows.Forms;
using System.Linq;

namespace Pr6_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//1.1
		private void random1_button_Click(object sender, EventArgs e)
		{
			try
			{
				random1_box.Enabled = true;
				random1_box.ReadOnly = true;
				Ok1_button.Enabled = false;
				input1_box.Clear();
				int num = Convert.ToInt32(size_box.Text);
				Random rand = new Random();
				if (num <= 0) throw new Exception("Некорректное значение размера массива");
				else
				{
					int[] array = new int[num];
					string arr = "";
					for (int i = 0; i < num; i++)
					{
						array[i] = rand.Next(-10, 10);
						arr += $"{array[i]}	";
					}
					random1_box.Text = arr;
					string rez = "";
					for (int i = 0; i < num; i++)
					{
						if ((Math.Abs(array[i]) % 2) == 1) rez += $"{i}	";
					}
					elements1_box.Text = rez;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void input1_button_Click(object sender, EventArgs e)
		{
			input1_box.Enabled = true;
			Ok1_button.Enabled = true;
			random1_box.Clear();
		}
		private void Ok1_button_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(size_box.Text);
				if (num <= 0) throw new Exception("Некорректное значение размера массива");
				else
				{
					int[] array = new int[num];
					string rez = "";
					string[] split = input1_box.Text.Split(' ');
					if (split.Length != num) throw new Exception("Размер введеного массива не совпадает с указаным размером");
					else
					{
						for (int i = 0; i < num; i++)
							array[i] = Convert.ToInt32(split[i]);
						for (int i = 0; i < num; i++)
						{
							if ((Math.Abs(array[i]) % 2) == 1) rez += $"{i}	";
						}
						elements1_box.Text = rez;
					}
				}
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		//1.2
		private void random2_button_Click(object sender, EventArgs e)
		{
			array_tabel.ReadOnly = true;
			Random rand = new Random();
			int rows = Convert.ToInt32(rows_box.Text);
			int columns = Convert.ToInt32(columns_box.Text);
		
			if (rows <= 0 || columns <= 0) throw new Exception("Некорректное значение размера массива");
			else
			{
				array_tabel.RowCount = rows;
				array_tabel.ColumnCount = columns;
				int[,] matrix = new int[rows, columns];
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						matrix[i, j] = rand.Next(-10, 10);
						array_tabel.Columns[j].Width = 30;
						array_tabel.Rows[i].Cells[j].Value = matrix[i, j];
					}
				}
				string rez = "";
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						if ((Math.Abs(matrix[i, j]) % 2) == 1) rez+=($"[{i}, {j}]\n");
					}
				}
				elements2_box.Text = rez;
			}
		}

		private void input2_button_Click(object sender, EventArgs e)
		{
			int rows = Convert.ToInt32(rows_box.Text);
			int columns = Convert.ToInt32(columns_box.Text);
			if (rows <= 0 || columns <= 0) throw new Exception("Некорректное значение размера массива");
			else
			{
				array_tabel.RowCount = rows;
				array_tabel.ColumnCount = columns;
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						array_tabel.Columns[j].Width = 30;
					}
				}
			}
		}

		private void Ok2_button_Click(object sender, EventArgs e)
		{
			try
			{
				int rows = Convert.ToInt32(rows_box.Text);
				int columns = Convert.ToInt32(columns_box.Text);
				int[,] matrix = new int[rows, columns];
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						matrix[i, j] = Convert.ToInt32(array_tabel.Rows[i].Cells[j].Value);
					}
				}
				string rez = "";
				for (int i = 0; i < rows; i++, Console.WriteLine())
				{
					for (int j = 0; j < columns; j++)
					{
						if ((Math.Abs(matrix[i, j]) % 2) == 1) rez += ($"[{i}, {j}]\n");
					}
				}
				elements2_box.Text = rez;
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}
		//2
		private void random3_button_Click(object sender, EventArgs e)
		{
			try
			{
				array_box.ReadOnly = true;
				int num = Convert.ToInt32(size2_box.Text);
				if (num <= 0) throw new Exception("Некорректный размер массива");
				else
				{
					int[] array = new int[num];
					Random rand = new Random();
					string arr = "";
					for (int i = 0; i < num; i++)
					{
						array[i] = rand.Next(-10, 10);
						arr += $"{array[i]} ";
					}
					array_box.Text = arr;
					int max = array.Min();
					if (max >= 0) throw new Exception("В массиве нет отрицательных элементов");
					else
					{
						foreach (int element in array)
							if (element < 0 && element > max) max = element;
						max_box.Text = max.ToString();
					}
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void input3_button_Click(object sender, EventArgs e)
		{
			try
			{
				array_box.ReadOnly = false;
				string[] split = array_box.Text.Split(' ');
				int num = Convert.ToInt32(size2_box.Text);
				if (split.Length != num) throw new Exception("Размер введеного массива не совпадает с указаным размером");
				else
				{
					int[] array = new int[num];
					for (int i = 0; i < num; i++)
						array[i] = Convert.ToInt32(split[i]);
					int max = array.Min();
					if (max >= 0) throw new Exception("В массиве нет отрицательных элементов");
					else
					{
						foreach (int element in array)
							if (element < 0 && element > max) max = element;
						max_box.Text = max.ToString();
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		//3
		private void random4_button_Click(object sender, EventArgs e)
		{
			try
			{
				array3_tabel.ReadOnly = true;
				Random rand = new Random();
				int rows = Convert.ToInt32(rows3_box.Text);
				int columns = Convert.ToInt32(columns3_box.Text);
				if (rows <= 0 || columns <= 0) throw new Exception("Некорректное значение размера массива");
				else
				{
					array3_tabel.RowCount = rows;
					array3_tabel.ColumnCount = columns;
					int[,] matrix = new int[rows, columns];
					for (int i = 0; i < rows; i++)
					{
						for (int j = 0; j < columns; j++)
						{
							matrix[i, j] = rand.Next(-10, 10);
							array3_tabel.Columns[j].Width = 30;
							array3_tabel.Rows[i].Cells[j].Value = matrix[i, j];
						}
					}
					string rez = "";
					for (int i = 0; i < rows; i++, rez += "\n")
					{
						if (i % 2 == 0)
						{
							for (int j = 0; j < columns; j++)
							{
								rez += matrix[i, j].ToString() + " ";
							}
						}
						if (i % 2 == 1)
						{
							for (int j = columns - 1; j >= 0; j--)
							{
								rez += matrix[i, j].ToString() + " ";
							}
						}
					}
					snake_array_box.Text = rez;
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		//4
		private int[][] Input_array()
		{
			Random rand = new Random();
			int num = Convert.ToInt32(n_box.Text);
			int[][] array = new int[num][];
			for (int i = 0; i < num; ++i)
			{
				array[i] = new int[num];
				for (int j = 0; j < num; ++j)
				{
					array[i][j] = rand.Next(-10, 10);
				}
			}
			return array;
		}
		private void Print_array(int[][] array)
		{
			string rez = "";
			for (int i = 0; i < array.Length; ++i, rez+="\n")
				for (int j = 0; j < array[i].Length; ++j)
					rez+=$"{array[i][j]}   ";
			mas_box.Text = rez;
		}
		private int sum(int[] array, int k1, int k2)
		{
			int sum = 0;
			for (int i = k1; i <= k2; i++)
			{
				sum += array[i];
			}
			return sum;
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			try
			{
				int[][] array = Input_array();
				Console.WriteLine("Массив: ");
				Print_array(array);
				int[] rez = new int[array.Length];
				int k1 = Convert.ToInt32(k1_box.Text);
				int k2 = Convert.ToInt32(k2_box.Text);
				string sum_rez = "";
				if (k1 < array.Length && k2 < array.Length && k1 < k2)
				{
					for (int i = 0; i < array.Length; ++i)
						rez[i] = sum(array[i], k1, k2);
					for (int i = 0; i < rez.Length; i++, sum_rez+="\n")
						sum_rez+=rez[i].ToString();
					sum_box.Text = sum_rez;
				}
				else throw new Exception("Индекс выходит за пределы массива");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
