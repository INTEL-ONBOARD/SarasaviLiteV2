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
        public DbSet<Stationary> Stationaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K0HI58E;Initial Catalog=SarasaviDb;Integrated Security=True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer(@"Data Source=VitaminC\SQLEXPRESS;Initial Catalog=SarasaviDb;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
