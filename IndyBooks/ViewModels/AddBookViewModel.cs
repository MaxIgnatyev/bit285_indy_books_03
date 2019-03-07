using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IndyBooks.Models;

namespace IndyBooks.ViewModels
{
    public class AddBookViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string SKU { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Author Name")]
        public String Name { get; set; }

        //Add properties to support a Writer's SelectList (Id and WritersList)
        public long AuthorId { get; set; }
        public List<Writer> WritersList { get; set; }
        //public List<Book> Books { get; set; }
    }
}
