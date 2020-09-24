using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.Models
{
    class Context : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Quarto> Quartos { get; set; }

        public DbSet<Hospedagem> Hospedagens { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<ServicoHospedagem> ServicosHospedagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocaldb;Database=HotelFPW;Trusted_Connection=true");

        }


    }
}
