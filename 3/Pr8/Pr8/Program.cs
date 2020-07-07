using System;
using System.Text.RegularExpressions;

namespace Pr8
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Regex r = new Regex(@"((1\d\d|2([0-4]\d|5[0-5])|\D\d\d?)\.?){4}$");
				Console.Write("Введите предложение: "); string text = Console.ReadLine();
				if (text == "") throw new Exception("Пустая строка");
				else
				{
					char[] splitters = { ';', ',', ' ', '!', '?', ':' };
					string[] splitText = text.Trim().Split(splitters);
					Console.WriteLine("IP-адреса, встречающиеся в тексте");
					foreach (string str in splitText)
					{
						if (r.IsMatch(str))
						{
							Console.WriteLine(str);
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
