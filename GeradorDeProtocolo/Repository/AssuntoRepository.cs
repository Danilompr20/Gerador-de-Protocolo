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
    public class AssuntoRepository : BaseRepository<Assunto>, IAssuntoRepository
    {
        public AssuntoRepository(ProtocoloContext context) : base(context)
        {

        }
        public Assunto BuscaPorId(int id)
        {
            return _context.Assuntos.FirstOrDefault(x=> x.AssuntoId==id );
        }

       

      
        public  IEnumerable<Assunto> BuscarAssuntoComGrupo()
        {
            return _context.Assuntos.Include(g => g.GrupoAssuntoId).ToList();
        }
    }
}
