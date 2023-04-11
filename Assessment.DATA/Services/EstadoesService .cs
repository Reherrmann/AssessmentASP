using Assessment.DATA.Interfaces;
using Assessment.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DATA.Services
{
    public class EstadoService
    {
        public RepositoryEstado oRepositoryEstado { get; set; }

        public EstadoService() 
        {
            oRepositoryEstado = new RepositoryEstado();
                }



    }
}
