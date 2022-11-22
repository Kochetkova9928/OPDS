using System;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace OPDS.Models
{
	public class BookModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public List<CategoryModel> Categories { get; set; } = new();

        public BookModel()
		{
        }
	}
}

