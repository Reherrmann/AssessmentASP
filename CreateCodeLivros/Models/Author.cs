﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateCodeLivros.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}