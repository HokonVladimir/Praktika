using System;
using System.IO;
using System.Collections.Generic;

namespace Pr13
{
	public abstract class Edition
	{
		protected string _name;
		protected string _autor;
		protected Edition() { }
		protected Edition(string name, string autor)
		{
			_name = name;
			_autor = autor;
		}
		public abstract void info();
		public bool is_required(string Lastname) => _autor == Lastname;
	}
	public class Book : Edition
	{
		private string _year;
		private string _publisher;
		public Book(string name, string autor, string year, string publisher) : base(name, autor)
		{
			_year = year;
			_publisher = publisher;
		}
		public override void info()
		{
			Console.WriteLine($"КНИГА\n" +
				$"Название: {_name}\n" +
				$"Фамилия автора: {_autor}\n" +
				$"Год издания: {_year}\n" +
				$"Издательство: {_publisher}");
		}
	}
	public class Article : Edition
	{
		private string _journal;
		private string _year;
		private string _number;
		public Article(string name, string autor, string journal, string year, string number) : base(name, autor)
		{
			_journal = journal;
			_year = year;
			_number = number;
		}
		public override void info()
		{
			Console.WriteLine($"СТАТЬЯ\n" +
				$"Название: {_name}\n" +
				$"Фамилия автора: {_autor}\n" +
				$"Год издания: {_year}\n" +
				$"Журнал: {_journal}\n" +
				$"Номер журнала: {_number}");
		}
	}
	public class Electronic_resource : Edition
	{
		private string _link;
		private string _annotation;
		public Electronic_resource(string name, string autor, string link, string annotation) : base(name, autor)
		{
			_link = link;
			_annotation = annotation;
		}
		public override void info()
		{
			Console.WriteLine($"ЭЛЕККТРОННЫЙ РЕСУРС\n" +
				$"Название: {_name}\n" +
				$"Фамилия автора: {_autor}\n" +
				$"Ссылка: {_link}\n" +
				$"Аннотоция: {_annotation}\n");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			try
			{

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			string path = @"Edition.txt";
			List<Edition> editions_list = new List<Edition>();
			string[] all_jlines = File.ReadAllLines(path);
			for (int i = 0; i < all_jlines.Length; i++)
			{
				string[] position = all_jlines[i].Split(';');
				if (position.Length == 4)
				{
					if (char.IsDigit(position[2][0]))
					{
						Book book = new Book(position[0], position[1], position[2], position[3]);
						editions_list.Add(book);
					}
					else
					{
						Electronic_resource electronic_resource = new Electronic_resource(position[0], position[1], position[2], position[3]);
						editions_list.Add(electronic_resource);
					}
				}
				else
				{
					if (position.Length == 5)
					{
						Article article = new Article(position[0], position[1], position[2], position[3], position[4]);
						editions_list.Add(article);
					}
					else throw new Exception("Некорректная считаная строка");
				}
			}
			foreach (Edition position in editions_list)
			{
				position.info();
				Console.WriteLine();
			}
			int count = 0;
			Console.Write("Введите фамилию автора: "); string Lastname = Console.ReadLine();
			Console.WriteLine(Lastname);
			foreach (Edition position in editions_list)
			{
				if (position.is_required(Lastname)) count++;
			}
			if (count != 0)
			{
				foreach (Edition position in editions_list)
				{
					if (position.is_required(Lastname)) position.info();
				}
			}
			else Console.WriteLine("Нет записей, удовлетворяющих условию поиска");
			Console.ReadLine();
		}
	}
}

