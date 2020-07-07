using System;

namespace Pr4_1
{
	class Program
	{
		static uint Evklid(uint a, uint b)
		{
			if (a == b) return a;
			else
			{
				if (a > b) return Evklid(a - b, b);
				else return Evklid(a, b - a);
			}
		}
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите число а: "); uint a = Convert.ToUInt32(Console.ReadLine());
				Console.Write("Введите число b: "); uint b = Convert.ToUInt32(Console.ReadLine());
				if (a <= 0 || b <= 0) throw new Exception("Введице целые, неотрицательные числа!");
				else
					Console.WriteLine($"НОД для чисел {a} и {b} = {Evklid(a, b)}");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
