using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeradorDeProtocolo.Models;

namespace GeradorDeProtocolo.Database
{
    public class ProtocoloContext : DbContext
    {
        public ProtocoloContext(DbContextOptions<ProtocoloContext> options) : base(options)
        {
            
        }
        public DbSet<Assunto> Assuntos { get; set; }
        public DbSet<GrupoAssunto> GrupoAssuntos { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Sublocal> sublocais { get; set; }
        public DbSet<OrigemDeAbertura> OrigemDeAberturas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
