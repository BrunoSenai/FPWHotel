using HotelFPW.Models;
using HotelFPW.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.DAL
{
    class ClienteDAO
    {
        private static Context _context = new Context();

        public static bool Cadastrar(Cliente c)
        {
            if (ValidacaoCPF.ValidarCpf(c.Cpf))
            {
                c.Cpf = c.Cpf.Replace(".", "").Replace("-", "");
                if (BuscarPorCpf(c.Cpf) == null)
                {
                    _context.Clientes.Add(c);
                    _context.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        public static List<Cliente> Listar() => _context.Clientes.ToList();

        public static Cliente BuscarPorCpf(string cpf) => _context.Clientes.FirstOrDefault(x => x.Cpf.Equals(cpf));

        public static List<Cliente> BuscarPorNome(string nome) => _context.Clientes.Where(x => x.NomeCliente.Contains(nome)).ToList();

        public static void Editar(Cliente c)
        {
            try
            {
                _context.Clientes.Update(c);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao editar");
            }
        }

        public static void Excluir(Cliente c)
        {
            try
            {
                _context.Clientes.Remove(c);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao excluir");
            }
        }

    }
}
