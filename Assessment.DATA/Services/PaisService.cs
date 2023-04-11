using Assessment.DATA.Interfaces;
using Assessment.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DATA.Services
{
    public class PaisService
    {
        public RepositoryPais oRepositoryPais { get; set; }

        public PaisService() 
        {
            oRepositoryPais = new RepositoryPais();
                }



    }
}
