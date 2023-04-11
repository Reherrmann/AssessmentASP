using amigos.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static amigos.DATA.Interface.IRepositoryModel;

namespace amigos.DATA.Repositorie
{
   
        public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
        {

            protected LocalDBMSSQLLocalDBContext _Contexto;
            public bool _SaveChanges = true;

            public RepositoryBase(bool savechanges = true)
            {
                _SaveChanges = savechanges;
                _Contexto = new LocalDBMSSQLLocalDBContext();
            }


            public T Alterar(T objeto)
            {
                _Contexto.Entry(objeto).State = EntityState.Modified;

                if (_SaveChanges)
                {
                    _Contexto.SaveChanges();
                }
                return objeto;
            }

            public void Dispose()
            {
                _Contexto.Dispose();
                if (_SaveChanges)
                {
                    _Contexto.SaveChanges();
                }
            }

            public void Excluir(T objeto)
            {
                _Contexto.Set<T>().Remove(objeto);
                if (_SaveChanges)
                {
                    _Contexto.SaveChanges();
                }
            }

            public void Excluir(params object[] variavel)
            {
                var obj = SelecionarPK(variavel);
                Excluir(obj);
            }

            public T Incluir(T objeto)
            {
                _Contexto.Set<T>().Add(objeto);
                if (_SaveChanges)
                {
                    _Contexto.SaveChanges();
                }
                return objeto;
            }

            public void Savechanges()
            {
                _Contexto.SaveChanges();
            }

            public List<T> SelecionarTodos(params object[] variavel)
            {
                throw new NotImplementedException();
            }

            public List<T> SelecionarTodos()
            {
                return _Contexto.Set<T>().ToList();
            }

            public T SelecionarPK(params object[] variavel)
            {
                return _Contexto.Set<T>().Find(variavel);
            }
        }
    
}
