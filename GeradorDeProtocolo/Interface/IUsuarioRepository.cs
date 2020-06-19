using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Interface
{
   public  interface IUsuarioRepository: IBaseRepository<Usuario>
    {
        Usuario BuscarPorId(int id);
    }
}
