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
        public DbSet<Item> GetItems() { 
            return context.Items; 
        } 

        public string CreateBook(string ISBN, string Title, Author author, string Year )
        {
            try
            {
            Book book = new Book()
            {
                ISBN = Convert.ToInt32(ISBN),
                Title = Title,
                Author = author,
                Year = Convert.ToInt32(Year)
            };
            context.Books.Add(book);
            }catch (Exception ex)
            {
                return "ISBN and Year has to be valid numbers";
            }

            context.SaveChanges();
            return "";
        }

        public string UpdateBook(int ID ,string ISBN, string Title, Author author, string Year)
        {
            try
            {
                Book book = context.Books.FirstOrDefault(book => book.Id == ID);
                book.ISBN = Convert.ToInt32(ISBN);
                book.Title = Title;
                book.Author = author;
                book.Year = Convert.ToInt32(Year);

                context.Books.Update(book);
            }
            catch (Exception ex)
            {
                return "ISBN and Year has to be valid numbers";
            }

            context.SaveChanges();
            return "";
        }

        public bool DeleteBook(int ID)
        {
            Book book = context.Books.FirstOrDefault(book => book.Id == ID);
            context.Books.Remove(book);
            context.SaveChanges();

            return true;
        }

        public DbSet<Author> GetAuthors()
        {
            return context.Authors;
        }

        public DbSet<Stationary> GetStationaries()
        {
            return context.Stationaries;
        }

        public string CreateStationary(string Distributer, string Type)
        {
            try
            {
                Stationary stationary = new Stationary()
                {
                    Distributer = Distributer,
                    Type = Type
                };
                context.Stationaries.Add(stationary);
            }
            catch (Exception ex)
            {
                return "Failed to add stationary due to an error.";
            }

            context.SaveChanges();
            return "";
        }

        public string UpdateStationary(int ID, string Distributer, string Type)
        {
            try
            {
                Stationary stationary = context.Stationaries.FirstOrDefault(item => item.Id == ID);
                stationary.Distributer = Distributer;
                stationary.Type = Type;
                context.Stationaries.Update(stationary);
            }
            catch (Exception ex)
            {
                return "Failed to add stationary due to an error.";
            }

            context.SaveChanges();
            return "";
        }

        public bool DeleteStationary(int ID)
        {
            Stationary stationary = context.Stationaries.FirstOrDefault(item => item.Id == ID);

            context.Stationaries.Remove(stationary);
            context.SaveChanges();

            return true;
        }

        public DbSet<Voucher> GetVouchers()
        {
            return context.Vouchers;
        }

        public string CreateVouchers(string Qty, DateTime ValidUntil, string Status, string Value)
        {
            try
            {
                Voucher voucher = new Voucher()
                {
                    Qty = Convert.ToInt32(Qty),
                    ValidUntil = ValidUntil,
                    Status = Status,
                    Value = Convert.ToDecimal(Value)
                };
                context.Vouchers.Add(voucher);
            }
            catch (Exception ex)
            {
                return "Quantity has to be a valid number and Value has to be a decimal number.";
            }

            context.SaveChanges();
            return "";
        }

        public string UpdateVoucher(int ID, string Qty, DateTime ValidUntil, string Status, string Value)
        {
            try
            {
                Voucher voucher = context.Vouchers.FirstOrDefault(item => item.Id == ID);
                voucher.Qty = Convert.ToInt32(Qty);
                    voucher.ValidUntil = ValidUntil;
                    voucher.Status = Status;
                voucher.Value = Convert.ToDecimal(Value);
                context.Vouchers.Update(voucher);
            }
            catch (Exception ex)
            {
                return "Quantity has to be a valid number and Value has to be a decimal number.";
            }

            context.SaveChanges();
            return "";
        }

        public bool DeleteVoucher(int ID)
        {
            Voucher voucher = context.Vouchers.FirstOrDefault(item => item.Id == ID);

            context.Vouchers.Remove(voucher);
            context.SaveChanges();

            return true;
        }
    }
}
