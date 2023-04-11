using Assessment.DATA.Interfaces;
using Assessment.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.DATA.Repositories
{
    public class RepositoryEstadoes : RepositoryBase<Estadoes>, IRepositoryEstadoes
    {
       
            public RepositoryEstadoes(bool SaveChanges = true) : base(SaveChanges) 
            { 

            }
        
    }
}

