using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorDeProtocolo.Models;
namespace GeradorDeProtocolo.Interface
{
     public interface ILocalRepository : IBaseRepository<Local>
    {
        Local BuscarPorId(int id);
    }
}
