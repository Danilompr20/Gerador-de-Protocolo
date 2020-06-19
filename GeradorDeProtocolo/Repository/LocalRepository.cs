using GeradorDeProtocolo.Interface;
using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Database;
namespace GeradorDeProtocolo.Repository
{
    public class LocalRepository : BaseRepository<Local>, ILocalRepository
    {
        public LocalRepository(ProtocoloContext context) : base(context)
        {

        }
        public Local BuscarPorId(int id)
        {
            return _context.Locais.FirstOrDefault(x=> x.LocalId==id);
        }
    }
}
