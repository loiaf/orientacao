namespace Pousada.Domain.Entities;

public class Hospede
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string CPF { get; set; } = "";
}
public class Quarto
{
    public int Numero { get; set; }
    public string Tipo { get; set; } = "";
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }
    public bool Disponivel { get; set; } = true;
}
public class Reserva
{
public int Id { get; set; }

public required Hospede Hospede { get; set; }

public required Quarto Quarto { get; set; }

public DateTime Entrada { get; set; }

public DateTime Saida { get; set; }

public int QuantidadePessoas { get; set; }

public decimal ValorTotal { get; set; }

public string Status { get; set; } = "Ativa";
}