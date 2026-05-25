using Pousada.Application.Services;
using Pousada.Domain.Entities;

var service = new ReservaService();

var hospede = new Hospede
{
Id = 1,
Nome = "Iago",
CPF = "123456789"
};

var quarto = new Quarto
{
Numero = 101,
Tipo = "Luxo",
Capacidade = 2,
ValorDiaria = 250
};

var reserva = new Reserva
{
Id = 1,
Hospede = hospede,
Quarto = quarto,
Entrada = new DateTime(2026, 7, 10),
Saida = new DateTime(2026, 7, 15),
QuantidadePessoas = 2,
ValorTotal = 1250
};

bool criada = service.CriarReserva(reserva);

Console.WriteLine(criada
? "Reserva criada!"
: "Conflito de reserva!");