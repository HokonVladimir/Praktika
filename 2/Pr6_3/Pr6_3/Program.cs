using System;

namespace Pr6_3
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите количество строк: "); int rows = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите количество столбцов: "); int columns = Convert.ToInt32(Console.ReadLine());
				if (rows <= 0 || columns <= 0) throw new Exception("Некорректное значение массива");
				else
				{
					int[,] matrix = new int[rows, columns];
					Random rand = new Random();
					Console.WriteLine("Массив: ");
					for (int i = 0; i < rows; i++, Console.WriteLine())
					{
						for (int j = 0; j < columns; j++)
						{
							matrix[i, j] = rand.Next(0, 9);
							Console.Write($"{matrix[i, j]}   ");
						}
					}
					Console.WriteLine("Вывод массива 'змейкой': ");
					for (int i = 0; i < rows; i++, Console.WriteLine())
					{
						if (i % 2 == 0)
						{
							for (int j = 0; j < columns; j++)
							{
								Console.Write($"{matrix[i, j]}   ");
							}
						}
						else
						{
							for (int j = columns - 1; j >= 0; j--)
							{
								Console.Write($"{matrix[i, j]}   ");
							}
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
