using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeleteDataFirst.Controllers
{
    public class BooksController : ApiController
    {
        private DataContext _dataContext;

        public BooksController()
        {
            _dataContext = new DataContext();
        }

        public IEnumerable<Book> Get()
        {
            return _dataContext.Books;
        }

        public void Delete(Book book)
        {
            if(book != null)
            {
                var bookToRomove = _dataContext.Books.Where(b => b.BookId == book.BookId).SingleOrDefault();

                if (bookToRomove != null) { 
                _dataContext.Books.Remove(bookToRomove);  
                _dataContext.SaveChangesAsync();
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _dataContext != null)
            {
                _dataContext.Dispose();
                _dataContext = null;
            }
            base.Dispose(disposing);
        }

    }
}
