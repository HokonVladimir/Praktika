using System;

namespace Pr7_2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите текст: "); string message = Console.ReadLine();
				int min = message.Length;
				char[] splitters = { ' ', ',', '.', '?', '!', ':', ';' };
				string[] array = message.Trim().Split(splitters);
				foreach (string word in array)
				{
					if (word.Length < min) min = word.Length;
				}
				foreach (string word in array)
				{
					if (word.Length == min) Console.Write(word);
				}
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		
			Console.ReadLine();
		}
	}
}
