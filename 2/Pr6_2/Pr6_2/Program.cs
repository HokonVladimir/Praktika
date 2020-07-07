using System;
using System.Linq;

namespace Pr6_2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите размер массива: "); int num = Convert.ToInt32(Console.ReadLine());
				if (num <= 0) throw new Exception("Некорректный размер массива");
				else
				{
					int[] array = new int[num];
					Random rand = new Random();
					for (int i = 0; i < num; i++)
					{
						array[i] = rand.Next(-10, 10);
						Console.Write($"array[{i}] = {array[i]}; ");
					}
					Console.WriteLine();
					int max = array.Min();
					if (max >= 0) throw new Exception("В массиве нет отрицательных элементов");
					else
					{
						foreach (int element in array)
							if (element < 0 && element > max) max = element;
						Console.WriteLine($"Максимальный отрицательный элемент: {max}");
					}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
