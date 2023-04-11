using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace UpdadeModelFirst.Controllers
{
    public class BooksController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            var books = new List<Book>();


            using (var connection = new EntityConnection("name=DataContext"))
            {
                connection.Open();

                string esqlQuery = @"SELECT VALUE books FROM
                                       DataContext.Books AS books";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = esqlQuery;

                    using (var dataReader = command.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        while (dataReader.Read())
                        {
                            var book = new Book();

                            book.BookId = (int)dataReader["BookId"];
                            book.Isbn = dataReader["Isbn"] as string;
                            book.Title = dataReader["Title"] as string;

                            books.Add(book);
                        }
                    }
                }
                connection.Close();
            }


            return books;
        }

        public void Put(Book book)
        {
            using (var context = new DataContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var bookToUpdate = context.Books.Where(b => b.BookId == book.BookId).FirstOrDefault();
                        if (bookToUpdate != null)
                        {
                            bookToUpdate.Isbn = book.Isbn;
                            bookToUpdate.Title = book.Title;
                            bookToUpdate.Authors = book.Authors;
                        }

                        context.SaveChanges();

                        dbContextTransaction.Commit();
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                    }
                }
            }

        }
    }
}
