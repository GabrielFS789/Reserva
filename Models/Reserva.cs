using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedes.Models
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> lista)
        {
            Suite suite = Suite;
            if (lista.Count <= suite.Capacidade)
            {
                Hospedes = lista;
            }
            throw new Exception("Quantidade de hospedes maior do que a capacidade da suite");

        }

        public void CadastraSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalculaValorDiaria()
        {
            Suite suite = Suite;
            decimal valorTotal = suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
                decimal valorComDesconto = valorTotal - (valorTotal * 0.1M);
                return valorComDesconto;
            }
            return valorTotal;
        }
        public void ListarHospedes()
        {
            foreach (Pessoa p in Hospedes)
            {
                Console.WriteLine(p.Nome);
            }
        }
    }
}
