using System;

namespace PR5_1
{
	class Program
	{
		static double function(double x)
		{
			if (x <= -0.2) throw new Exception();
			else return Math.Log(x - 2)/Math.Sqrt(5 * x - 1);
		}
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите начальную границу диапазона: "); double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите конечную границу диапазона: "); double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите шаг: "); double h = Convert.ToDouble(Console.ReadLine());
				if (h <= 0) throw new Exception("Некорректное значение шага");
				else
				{
					for (double i = a; i <= b; i += h)
					{
						try
						{
							Console.WriteLine($"y({i}) = {function(i)};");
						}
						catch
						{
							Console.WriteLine($"y({i}) = error;");
						}
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
