using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeProtocolo.Models
{
    public class Sublocal
    {
        public int SublocalId { get; set; }
        public string SublocalDescricao { get; set; }
        public string ? SublocalDiasPermanecia { get; set; }
        public int LocalId { get; set; }
        public Local Local { get; set; }
    }
}
