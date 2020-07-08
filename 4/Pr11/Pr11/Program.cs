using System;

namespace Pr11
{
	class Rectangle
	{
		private int _sideA, _sideB;
		public Rectangle() { }
		public Rectangle(int sideA,int sideB)
		{
			_sideA = sideA;
			_sideB = sideB;
		}
		public int SideA_
		{
			set{
				_sideA = value;
			}
			get{
				return _sideA;
			}
		}
		public int SideB_
		{
			set
			{
				_sideB = value;
			}
			get
			{
				return _sideB;
			}
		}
		public bool isSquare
		{
			get => _sideA == _sideB;
		}
		public void print_Rectangle()
		{
			Console.WriteLine($"Сторона А: {SideA_}\nСторона B: {SideB_}");
		}
		public int perimeter()=> SideA_ * 2 + SideB_ * 2;
		public int area() => SideB_ * SideA_;

	}
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите сторону А: "); int sideA = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите сторону B: "); int sideB = Convert.ToInt32(Console.ReadLine());
				Rectangle rectangle = new Rectangle(sideA, sideB);
				rectangle.print_Rectangle();
				Console.WriteLine($"Площадь прямоугольника: {rectangle.area()}");
				Console.WriteLine($"Периметр прямоугольника: {rectangle.perimeter()}");
				Console.WriteLine($"Является квадратом? {rectangle.isSquare}");
				Console.Write("Введите сторону квадрата: "); int square_side = Convert.ToInt32(Console.ReadLine());
				rectangle.SideA_ = square_side;
				rectangle.SideB_ = square_side;
				rectangle.print_Rectangle();
				Console.WriteLine($"Является квадратом? {rectangle.isSquare}");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
