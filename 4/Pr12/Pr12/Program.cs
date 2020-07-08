using System;

namespace Pr12
{
	class Program
	{
		class Rectangle
		{
			private int _sideA, _sideB;
			public Rectangle() { }
			public Rectangle(int sideA, int sideB)
			{
				_sideA = sideA;
				_sideB = sideB;
			}
			public int SideA_
			{
				set
				{
					_sideA = value;
				}
				get=> _sideA;
			}
			public int SideB_
			{
				set
				{
					_sideB = value;
				}
				get=>_sideB;
			}
			public bool isSquare
			{
				get => _sideA == _sideB;
			}
			public void print_Rectangle()
			{
				Console.WriteLine($"Сторона А: {SideA_}\nСторона B: {SideB_}");
			}
			public int perimeter() => SideA_ * 2 + SideB_ * 2;
			public int area() => SideB_ * SideA_;
			//12
			int this[int index]
			{
				set
				{
					if (index == 0) SideA_ = value;
					else
					{
						if (index == 1) SideB_ = value;
						else throw new Exception("Индекс находится за пределами допустимых значений");
					}
				}
				get
				{
					if (index == 0) return SideA_;
					else
					{
						if (index == 1) return SideB_;
						else throw new Exception("Индекс находится за пределами допустимых значений");
					}
				}
			}
			public static Rectangle operator ++(Rectangle rectangle)
			{
				rectangle.SideA_++;
				rectangle.SideB_++;
				return rectangle;
			}
			public static Rectangle operator --(Rectangle rectangle)
			{
				rectangle.SideA_--;
				rectangle.SideB_--;
				return rectangle;
			}
			public static bool operator true(Rectangle rectangle) => rectangle.isSquare;
			public static bool operator false(Rectangle rectangle) => rectangle.isSquare;
			public static Rectangle operator *(Rectangle rectangle, int scalar)
			{
				rectangle.SideA_ *= scalar;
				rectangle.SideB_ *= scalar;
				return rectangle;
			}
			public static implicit operator string(Rectangle rectangle) => $"Сторона А: {rectangle[0].ToString()}\nСторона В: {rectangle[1].ToString()}";
			public static implicit operator Rectangle(string s)
			{
				string[] str = s.Split(' ');
				return new Rectangle(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
			}
		}
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите стороны прямоугольника(через пробел): "); Rectangle rectangle = Console.ReadLine();
				Console.WriteLine(rectangle);
				Console.Write("Введите число, на которое необходимо умножить стороны прямоугольника: "); int scalar = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Результат умножения:\n{(string)(rectangle * scalar)}");
				Console.WriteLine($"Инкремент:\n{(string)(rectangle++)}");
				rectangle--;
				Console.WriteLine($"Декремент:\n{(string)(rectangle--)}");
				if (rectangle) Console.WriteLine("Является квадратом");
				else Console.WriteLine("Не является квадратом");
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
	}
}
