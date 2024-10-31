using Hospedes.Models;
using System.Reflection.Metadata.Ecma335;

try
{

    List<Pessoa> hospedes = new List<Pessoa>();

    Pessoa p1 = new Pessoa("Gabriel", "Felipe");
    Pessoa p2 = new Pessoa("Douflas");
    hospedes.Add(p1);
    hospedes.Add(p2);


    Suite s1 = new Suite("premium", 5, 10.3M);


    Reserva reserva = new Reserva(diasReservados: 10);
    reserva.CadastraSuite(s1);
    reserva.CadastrarHospedes(hospedes);
    reserva.ListarHospedes();
    decimal valorReserva = reserva.CalculaValorDiaria();
    int quantidadeHospides = reserva.ObterQuantidadeHospedes();

    Console.WriteLine($"Hóspedes: {quantidadeHospides}");
    Console.WriteLine($"Valor Diaria: {valorReserva}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}