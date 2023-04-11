using Assessment.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assessment.DATA.Interfaces;
using System.Threading.Tasks;
using amigos.DATA.Models;
using amigos.DATA.Interface;

namespace amigos.DATA.Repositorie
{
    public class RepositoryAmigo : RepositoryBase<Amigo>, IRepositoryAmigo
    {

        public RepositoryAmigo(bool SaveChanges = true) : base(SaveChanges)
        {

        }

    }
}
