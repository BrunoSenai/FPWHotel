using HotelFPW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.DAL
{
    class ServicoDAO
    {
        private static Context _context = new Context();

        public static void Cadastrar(Servico s)
        {
            _context.Servicos.Add(s);
            _context.SaveChanges();

        }

        public static List<Servico> Listar() => _context.Servicos.ToList();

        public static List<Servico> BuscarPorNome(string nome) => _context.Servicos.Where(x => x.DescricaoServico.Contains(nome)).ToList();

        public static void Editar(Servico s)
        {
            try
            {
                _context.Servicos.Update(s);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao editar");
            }
        }

        public static void Excluir(Servico s)
        {
            try
            {
                _context.Servicos.Remove(s);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao excluir");
            }
        }
    }
}
