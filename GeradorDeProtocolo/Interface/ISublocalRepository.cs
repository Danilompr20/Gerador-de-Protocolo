using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Interface
{
     public interface ISublocalRepository : IBaseRepository<Sublocal>
    {
        Sublocal BuscarPorId(int id);

        IEnumerable<Sublocal> ListarSubLocalComLocal();
    }
}
