using Microsoft.EntityFrameworkCore;
using SarasaviLite.Models;

namespace SarasaviLite.Data
{
    public class SarasaviContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<DiscountCoupen> DiscountCoupens { get; set; }
        public DbSet<Invoice> Invoices{ get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Payment> Payments{ get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1:3306;Database=wenuja_sarasavi;User Id=root;Password=;");
        }
    }
}
