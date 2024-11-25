namespace Labb2_BookStoreDB
{
    public class Inventory
    {
        public int StoreID { get; set; }
        public string ISBN13 { get; set; }
        public int Quantity { get; set; }

        // Navigation properties
        public Store Store { get; set; }
        public Book Book { get; set; }
    }
}
