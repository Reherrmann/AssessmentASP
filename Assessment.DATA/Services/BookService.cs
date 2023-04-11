using Assessment.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DATA.Services
{
    public class BookService
    {
        public RepositoyLista oRepositoyLista { get; set; }

        public BookService() 
        {
        oRepositoyLista = new RepositoyLista();
        }
    }
}
