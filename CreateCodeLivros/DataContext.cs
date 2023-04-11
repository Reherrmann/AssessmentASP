using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CreateCodeLivros.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CreateCodeLivros
{
    public class DataContext :DbContext
    {
        public DataContext() :base("DefaultConnection")
        { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}