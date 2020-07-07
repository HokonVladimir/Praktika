using System;

namespace Pr7_1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите строку: "); string str = Console.ReadLine();
				Console.Write("Введите символ: "); char symbol = Convert.ToChar(Console.ReadLine());
				if (str.IndexOf(symbol) == -1||str.LastIndexOf(symbol)==-1) throw new Exception("В строке нет заданного символа");
				else
				{
					Console.WriteLine($"Порядковый номер первого вхождения символа {symbol} в строку: {str.IndexOf(symbol) + 1} (индекс = [{str.IndexOf(symbol)}])");
					Console.WriteLine($"Порядковый номер последнего вхождения символа {symbol} в строку: {str.LastIndexOf(symbol) + 1} (индекс = [{str.LastIndexOf(symbol)}])");
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
