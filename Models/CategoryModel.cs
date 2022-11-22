using System;
using System.Collections.Generic;

namespace OPDS.Models
{
	public class CategoryModel
	{
		public int Id { get; set; }

        public string Name { get; set; }
        public List<BookModel> books { get; set; } = new();

        public CategoryModel()
		{
        }
	}
}

