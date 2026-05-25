using System.Collections.Generic;
using System.Linq;
using Pousada.Domain.Entities;

namespace Pousada.Application.Services;

public class ReservaService
{
	private List<Reserva> reservas = new();

	public bool CriarReserva(Reserva novaReserva)
	{
		bool conflito = reservas.Any(r =>
			r.Quarto.Numero == novaReserva.Quarto.Numero &&
			novaReserva.Entrada < r.Saida &&
			novaReserva.Saida > r.Entrada
		);

		if (conflito)
		{
			return false;
		}

		reservas.Add(novaReserva);

		return true;
	}

	public List<Reserva> ListarReservas()
	{
		return reservas;
	}
}