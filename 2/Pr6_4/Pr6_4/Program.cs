using System;

namespace Pr6_4
{
	class Program
	{
		static int[][] Input_array()
		{
			Console.Write("Введите размерность массива: "); int num = Convert.ToInt32(Console.ReadLine());
			int[][] array = new int[num][];
			for (int i = 0; i < num; ++i)
			{
				array[i] = new int[num];
				for (int j = 0; j < num; ++j)
				{
					Console.Write($"Array[{i},{j}]= ");
					array[i][j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			return array;
		}
		static void Print_array(int[][] array)
		{
			for (int i = 0; i < array.Length; ++i, Console.WriteLine())
				for (int j = 0; j < array[i].Length; ++j)
					Console.Write($"{array[i][j]}   ");
		}
		static int sum (int[] array, int k1, int k2)
		{
			int sum = 0;
			for(int i =k1; i <= k2; i++)
			{
				sum += array[i];
			}
			return sum;
		}
		static void Main(string[] args)
		{
			try
			{
				int[][] array = Input_array();
				Console.WriteLine("Массив: ");
				Print_array(array);
				int[] rez = new int[array.Length];
				Console.Write("Введите начальный индекс: "); int k1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите конечный индекс: "); int k2 = Convert.ToInt32(Console.ReadLine());
				if (k1 < array.Length && k2 < array.Length && k1 < k2)
				{
					for (int i = 0; i < array.Length; ++i)
						rez[i] = sum(array[i], k1, k2);
					Console.WriteLine("Результат: ");
					for (int i = 0; i < rez.Length; i++)
						Console.WriteLine(rez[i]);
				}
				else throw new Exception("Индекс выходит за пределы массива");
				
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
