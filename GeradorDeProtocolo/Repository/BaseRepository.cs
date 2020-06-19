using GeradorDeProtocolo.Database;
using GeradorDeProtocolo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected  ProtocoloContext _context;
        public BaseRepository(ProtocoloContext context)
        {
            _context = context;
        }
        public void Atualizar(T Entity)
        {
            _context.Set<T>().Update(Entity);
        }

        public void Cadastrar(T Entity)
        {
            _context.Set<T>().Add(Entity);
        }

        public void Excluir(T Entity)
        {
            _context.Set<T>().Remove(Entity);
        }

        public IEnumerable<T> ListarTodos()
        {
             return _context.Set<T>().ToList();
        }
    }
}
