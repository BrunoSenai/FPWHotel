using HotelFPW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.DAL
{
    class HospedagemDAO
    {

        private static Context _context = new Context();

        public static void Cadastrar(Hospedagem h)
        {
            _context.Hospedagens.Add(h);
            _context.SaveChanges();
        }

        public static List<Hospedagem> Listar() => _context.Hospedagens.ToList();

        public static Hospedagem BuscarClienteHospedadoCpf(string cpf)
            => _context.Hospedagens.FirstOrDefault(x => x.Cliente.Cpf.Equals(cpf));

        public static List<Hospedagem> BuscarClientesPorNome(string nome)
            => _context.Hospedagens.Where(x => x.Cliente.NomeCliente.Contains(nome)).ToList();

        public static void Editar(Hospedagem h)
        {
            _context.Hospedagens.Update(h);
            _context.SaveChanges();
        }

        public static void Excluir(Hospedagem h)
        {
            _context.Hospedagens.Remove(h);
            _context.SaveChanges();
        }

    }
}
