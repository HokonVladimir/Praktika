using System;

namespace Pr4_2
{
	class Program
	{
		static int buf;
		static void print(int N, int symbols = 1 )
		{
			for (int i = 0; i < symbols; i++)
				Console.Write('*');
			for (int i = 0; i < N; i++)
				Console.Write(' ');
			for (int i = 0; i < symbols; i++)
				Console.Write('*');
			Console.WriteLine();
			if (N > 0)
				print(N - 2, ++symbols);
			for (int i = 0; i < symbols-1; i++)
				Console.Write('*');
			for (int i = 0; i < N; i++)
				Console.Write(' ');
			for (int i = 0; i < symbols-1; i++)
				Console.Write('*');
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите N: "); buf = Convert.ToInt32(Console.ReadLine());
				print(buf);
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
