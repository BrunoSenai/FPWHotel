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
    class FuncionarioDAO
    {
        private static Context _context = new Context();

        public static bool Cadastrar(Funcionario f)
        {
            if (ValidacaoCPF.ValidarCpf(f.Cpf))
            {
                f.Cpf = f.Cpf.Replace(".", "").Replace("-", "");
                if (BuscarPorCpf(f.Cpf) == null)
                {
                    _context.Funcionarios.Add(f);
                    _context.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        public static List<Funcionario> Listar() => _context.Funcionarios.ToList();

        public static Funcionario BuscarPorCpf(string cpf) => _context.Funcionarios.FirstOrDefault(x => x.Cpf.Equals(cpf));

        public static List<Funcionario> BuscarPorNome(string nome) => _context.Funcionarios.Where(x => EF.Functions.Like(x.NomeFuncionario, "%" + nome + "%")).ToList();

        public static void Editar(Funcionario f)
        {
            _context.Funcionarios.Update(f);
            _context.SaveChanges();
        }

        public static void Excluir(Funcionario f)
        {
            _context.Funcionarios.Remove(f);
            _context.SaveChanges();
        }
    }
}
