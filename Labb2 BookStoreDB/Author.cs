using System;
using System.Collections.Generic;

namespace Labb2_BookStoreDB
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}
