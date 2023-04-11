using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }
    

    [Column("Book")]
    [Display(Name = "Book")]
    public string Book { get; set; }
    }
}
