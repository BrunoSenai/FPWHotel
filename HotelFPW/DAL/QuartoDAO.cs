using HotelFPW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.DAL
{
    class QuartoDAO
    {
        private static Context _context = new Context();

        public static bool Cadastrar(Quarto q)
        {

            if (BuscarQuartoPorNumero(q.NumeroQuarto) == null)
            {
                _context.Quartos.Add(q);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public static List<Quarto> Listar() => _context.Quartos.ToList();

        public static Quarto BuscarQuartoPorNumero(int numero)
            => _context.Quartos.FirstOrDefault(x => x.NumeroQuarto == numero);

        public static Quarto BuscarPorId(int id) => _context.Quartos.Find(id);

        public static List<Quarto> ListarVagos() => _context.Quartos.Where(x => x.Ocupado == false).ToList();

        public static void Editar(Quarto q)
        {
            _context.Quartos.Update(q);
            _context.SaveChanges();
        }

        public static void Excluir(Quarto q)
        {
            _context.Quartos.Remove(q);
            _context.SaveChanges();
        }
    }
}
