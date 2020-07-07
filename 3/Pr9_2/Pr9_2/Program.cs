using System;
using System.IO;
using System.Collections.Generic;

namespace Pr9_2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<string> collection = new List<string>();
				using (StreamReader sr = File.OpenText(@"C:\Users\IRU\Desktop\3-4\3\Pr9_2\Pr9_2\bin\Debug\Text.txt"))
					for (int i = 0; i < File.ReadAllLines(@"C:\Users\IRU\Desktop\3-4\3\Pr9_2\Pr9_2\bin\Debug\Text.txt").Length; i++)
					{
						collection.Add(sr.ReadLine());
					}
				Console.Write("Введите номер первой строки: "); int k1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите номер последней строки: "); int k2 = Convert.ToInt32(Console.ReadLine());
				if (k1 < collection.Count && k2 < collection.Count && k1 <= k2)
					for (int i = k1; i <= k2; i++)
						Console.WriteLine(collection[i]);
				else throw new Exception("Некорректный ввод");
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
