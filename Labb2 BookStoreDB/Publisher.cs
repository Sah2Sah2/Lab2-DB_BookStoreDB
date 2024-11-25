using System.Collections.Generic;

namespace Labb2_BookStoreDB
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string ContactEmail { get; set; }
        public string Phone { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}
