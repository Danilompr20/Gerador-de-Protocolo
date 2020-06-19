using GeradorDeProtocolo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Interface
{
     public interface IOrigemDeAberturaRepository : IBaseRepository<OrigemDeAbertura>
    {
        OrigemDeAbertura BuscarPorId(int id);
    }
}
