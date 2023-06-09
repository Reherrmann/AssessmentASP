﻿using System;
using CreateCodeLivros.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CreateCodeLivros.Controllers
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

        public void Post(Book book)
        {
            _dataContext.Books.Add(book);
            _dataContext.SaveChanges();
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
