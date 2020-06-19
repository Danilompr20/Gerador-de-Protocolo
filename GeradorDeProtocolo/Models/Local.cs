using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Models
{
    public class Local
    {
        public int LocalId { get; set; }
        public string LocalDescricao { get; set; }
        public int ? LocalDiasPermanencia { get; set; }
        public bool ? LocalAbertura { get; set; }
        //public ICollection<Sublocal> Sublocais { get; set; }
    }
}
