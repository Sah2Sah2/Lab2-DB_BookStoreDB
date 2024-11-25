using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb2_BookStoreDB
{
    public class Book
    {
        // Primary Key
        [Key] 
        public string ISBN13 { get; set; }

        // Other properties
        public string Title { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public DateTime PublicationDate { get; set; }

        // Foreign Keys
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }

        // Navigation properties
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
    }
}
