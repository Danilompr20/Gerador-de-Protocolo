using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Models
{
    public class Assunto
    {

        public int AssuntoId { get; set; }
        public string AssuntoDescricao { get; set; }
        public int GrupoAssuntoId { get; set; }
        public GrupoAssunto GrupoAssunto { get; set; }
    }
}
