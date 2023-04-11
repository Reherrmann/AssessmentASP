using Assessment.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        { 
        
        }


        public DbSet<Livro> Livro { get; set; }

        public DbSet<Pais> Paises { get; set; }

       



    }
}
