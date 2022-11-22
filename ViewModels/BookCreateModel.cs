using System;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace OPDS.ViewModels
{
	public class BookCreateModel
	{
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public List<int> CategoryIds { get; set; } = new();

        public BookCreateModel()
		{
        }
	}
}

