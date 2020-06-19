using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Interface
{
    public  interface IAssuntoRepository : IBaseRepository<Assunto>
    {
        Assunto BuscaPorId(int id );
        IEnumerable<Assunto> BuscarAssuntoComGrupo();
    }
}
