using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Interface
{
    public interface IGrupoAssuntoRepository : IBaseRepository<GrupoAssunto>
    {
        GrupoAssunto BuscarPorId(int id);
    }
}
