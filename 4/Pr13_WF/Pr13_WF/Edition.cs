using System;
using System.Windows.Forms;

namespace Pr13_WF
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
		public abstract void info(DataGridViewRow row);
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
		public override void info(DataGridViewRow row)
		{
			row.Cells["Name_column"].Value = _name;
			row.Cells["Autor_column"].Value = _autor;
			row.Cells["Year_column"].Value = _year;
			row.Cells["Publisher_column"].Value = _publisher;
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
		public override void info(DataGridViewRow row)
		{
			row.Cells["Name_column"].Value = _name;
			row.Cells["Autor_column"].Value = _autor;
			row.Cells["Year_column"].Value = _year;
			row.Cells["Journal_column"].Value =_journal;
			row.Cells["Number_column"].Value = _number;
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
		public override void info(DataGridViewRow row)
		{
			row.Cells["Name_column"].Value = _name;
			row.Cells["Autor_column"].Value = _autor;
			row.Cells["Link_column"].Value = _link;
			row.Cells["Annotation_column"].Value =_annotation;

		}
	}
}
