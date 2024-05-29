using Microsoft.EntityFrameworkCore;
using SarasaviLite.Data;
using SarasaviLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLite.Controller
{
    internal class InventoryController
    {
        SarasaviContext context;

        public InventoryController() {
            context = new SarasaviContext();
        }

        public DbSet<Book>  GetBooks() {
            return context.Books;
        }

        public bool SaveBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();

            return true;
        }

        public DbSet<Author> GetAuthors()
        {
            return context.Authors;
        }
    }
}
