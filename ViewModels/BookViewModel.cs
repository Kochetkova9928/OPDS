using System;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using OPDS.Models;

namespace OPDS.ViewModels
{
	public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Categories { get; set; }

        public BookViewModel(BookModel model)
		{
            this.Id = model.Id;
            this.Name = model.Name;
            this.Author = model.Author;
            this.Year = model.Year;
            this.Categories = string.Join(", ", model.Categories.ConvertAll(x => x.Name));
        }
	}
}

