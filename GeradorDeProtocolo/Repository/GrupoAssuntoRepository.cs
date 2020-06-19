using GeradorDeProtocolo.Interface;
using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Database;

namespace GeradorDeProtocolo.Repository
{
    public class GrupoAssuntoRepository : BaseRepository<GrupoAssunto>, IGrupoAssuntoRepository
    {
        public GrupoAssuntoRepository(ProtocoloContext context) : base(context)
        {

        }
        public GrupoAssunto BuscarPorId(int id)
        {
            return _context.GrupoAssuntos.FirstOrDefault(x=> x.GrupoAssuntoId==id);
        }
    }
}
