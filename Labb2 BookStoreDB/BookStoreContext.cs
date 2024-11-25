using Labb2_BookStoreDB;
using Microsoft.EntityFrameworkCore;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    // DbSet properties for each table in the database
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Inventory> Inventory { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Books Table: Foreign Keys to Author and Publisher
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books) 
            .HasForeignKey(b => b.AuthorID);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Publisher)
            .WithMany(p => p.Books) 
            .HasForeignKey(b => b.PublisherID);

        // Inventory Table: Composite Primary Key and Foreign Keys
        modelBuilder.Entity<Inventory>()
            .HasKey(i => new { i.StoreID, i.ISBN13 });

        modelBuilder.Entity<Inventory>()
            .HasOne(i => i.Store)
            .WithMany(s => s.Inventory)
            .HasForeignKey(i => i.StoreID);

        modelBuilder.Entity<Inventory>()
            .HasOne(i => i.Book)
            .WithMany(b => b.Inventory)
            .HasForeignKey(i => i.ISBN13);
    }
}
