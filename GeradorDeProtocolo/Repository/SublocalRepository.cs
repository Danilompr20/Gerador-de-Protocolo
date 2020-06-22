using GeradorDeProtocolo.Interface;
using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Database;
using Microsoft.EntityFrameworkCore;

namespace GeradorDeProtocolo.Repository
{
    public class SublocalRepository : BaseRepository<Sublocal>, ISublocalRepository

    {
        public SublocalRepository(ProtocoloContext context) : base(context)
        {

        }
        public Sublocal BuscarPorId(int id)
        {
             return _context.sublocais.FirstOrDefault(x=> x.SublocalId == id);
        }

        public IEnumerable<Sublocal> ListarSubLocalComLocal()
        {
            return _context.sublocais.Include(l => l.Local).ToList();
        }
    }
}
