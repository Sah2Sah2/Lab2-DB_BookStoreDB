using System.Collections.Generic;

namespace Labb2_BookStoreDB
{
    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }

        // Navigation property
        public ICollection<Inventory> Inventory { get; set; }
    }
}
