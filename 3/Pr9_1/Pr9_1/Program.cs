using System;
using System.IO;

namespace Pr9_1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите числа (в строку через пробел): "); string str = Console.ReadLine();
				double[] array = new double[str.Trim().Split(' ').Length];
				string[] splitText = str.Trim().Split(' ');
				FileStream f = new FileStream(@"C:\Users\IRU\Desktop\3-4\3\Pr9_1\Pr9_1\bin\Debug\Text.txt", FileMode.Open);
				BinaryWriter fOut = new BinaryWriter(f);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Convert.ToDouble(splitText[i]);
					fOut.Write(array[i]);
				}
				fOut.Close();
				f = new FileStream(@"C:\Users\IRU\Desktop\3-4\3\Pr9_1\Pr9_1\bin\Debug\Text.txt", FileMode.Open);
				BinaryReader fIn = new BinaryReader(f);
				long m = f.Length;
				double max = fIn.ReadDouble();
				for (long i = 8; i < m; i += 16)
				{
					f.Seek(i, SeekOrigin.Begin);
					if (fIn.ReadDouble() > max) max = fIn.ReadDouble();
				}
				Console.WriteLine($"Максимальное значение: {max}");
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
	
			Console.ReadLine();
		}
	}
}
