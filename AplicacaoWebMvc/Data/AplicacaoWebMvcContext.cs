using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicacaoWebMvc.Models;

namespace AplicacaoWebMvc.Data
{
    public class AplicacaoWebMvcContext : DbContext
    {
        public AplicacaoWebMvcContext (DbContextOptions<AplicacaoWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Fichario> Fichario { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Fichario> RegistroDeDizimo { get; set; }

        

        
    }
}
