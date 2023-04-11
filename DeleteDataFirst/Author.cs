namespace DeleteDataFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        public int AuthorId { get; set; }

        public string FistName { get; set; }

        public string LastName { get; set; }

        public int? Book_BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
