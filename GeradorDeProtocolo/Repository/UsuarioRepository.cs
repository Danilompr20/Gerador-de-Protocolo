using GeradorDeProtocolo.Interface;
using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Database;

namespace GeradorDeProtocolo.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {

        public UsuarioRepository(ProtocoloContext context) : base(context)
        {

        }
        public Usuario BuscarPorId(int id)
        {
           return  _context.usuarios.FirstOrDefault(x=>x.UsuarioId== id);
        }
    }
}
