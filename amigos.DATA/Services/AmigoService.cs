using amigos.DATA.Repositorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amigos.DATA.Services
{
    public class AmigoService
    {
        public RepositoryAmigo oRepositoryAmigo { get; set; }

        public AmigoService()
        { 
            oRepositoryAmigo = new RepositoryAmigo();
        
        }

    }
}
