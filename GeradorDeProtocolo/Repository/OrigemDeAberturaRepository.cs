using GeradorDeProtocolo.Interface;
using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Database;

namespace GeradorDeProtocolo.Repository
{
    public class OrigemDeAberturaRepository : BaseRepository<OrigemDeAbertura>, IOrigemDeAberturaRepository
    {
        public OrigemDeAberturaRepository(ProtocoloContext context) : base(context)
        {

        }
        public OrigemDeAbertura BuscarPorId(int id)
        {
            return _context.OrigemDeAberturas.FirstOrDefault(x=> x.OrigemDeAberturaId== id);
        }
    }
}
