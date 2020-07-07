using System;

namespace Pr6_1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("ОДНОМЕРНЫЙ МАССИВ");
				Console.Write("Введите размер массива: "); int num = Convert.ToInt32(Console.ReadLine());
				Random rand = new Random();
				if (num <= 0) throw new Exception("Некорректное значение размера массива");
				else
				{
					int[] array = new int[num];
					
					for (int i = 0; i < num; i++)
					{
						array[i] = rand.Next(-10, 10);
						Console.Write($"array[{i}] = {array[i]}		");
					}
					Console.WriteLine();
					Console.WriteLine("Номера нечетных элементов: ");
					for (int i = 0; i < num; i++)
					{
						if ((Math.Abs(array[i]) % 2) == 1) Console.Write($"{i}	");
					}
				}

				Console.WriteLine("\n\nДВУМЕРНЫЙ МАССИВ");
				Console.Write("Введите количество строк: "); int rows = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите количество столцов: "); int columns = Convert.ToInt32(Console.ReadLine());
				if(rows<=0||columns<=0) throw new Exception("Некорректное значение размера массива");
				else
				{
					int[,] matrix = new int[rows, columns];
					for (int i = 0; i < rows; i++, Console.WriteLine())
					{
						for (int j = 0; j < columns; j++)
						{
							matrix[i, j] = rand.Next(-10, 10);
							Console.Write($"{matrix[i, j]}  ");
						}
					}
					Console.WriteLine();
					Console.WriteLine("Номера нечетных элементов: ");
					for (int i = 0; i < rows; i++, Console.WriteLine())
					{
						for (int j = 0; j < columns; j++)
						{
							if ((Math.Abs(matrix[i, j]) % 2) == 1) Console.Write($"[{i}, {j}]	");
						}
					}
				}
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			Console.ReadLine();
		}
	}
}
