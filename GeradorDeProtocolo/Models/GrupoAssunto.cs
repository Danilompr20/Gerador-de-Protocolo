using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Models
{
    public class GrupoAssunto
    {
        public int GrupoAssuntoId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Assunto> Assuntos { get; set; }
    }
}
