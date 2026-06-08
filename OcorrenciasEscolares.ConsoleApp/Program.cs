using System;
using OcorrenciasEscolares.Domain;

namespace OcorrenciasEscolares.ConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            var service = new OcorrenciaService();

            service.AdicionarOcorrencia(new OcorrenciaDisciplinar(
                estudanteEnvolvido: "Iago Monteiro Lima",
                data: new DateTime(2026, 5, 28),
                descricao: "Atraso recorrente e uso de linguagem inadequada na sala de aula.",
                responsavelRegistro: "Prof. Carlos",
                grauInfracao: "Grave"));

            service.AdicionarOcorrencia(new OcorrenciaPedagogica(
                estudanteEnvolvido: "Iago Monteiro Lima",
                data: new DateTime(2026, 5, 29),
                descricao: "Dificuldade de compreensão em conteúdos de matemática.",
                responsavelRegistro: "Coordenação Pedagógica",
                disciplinaAssociada: "Matemática"));

            service.AdicionarOcorrencia(new OcorrenciaSaude(
                estudanteEnvolvido: "Iago Monteiro Lima",
                data: new DateTime(2026, 5, 30),
                descricao: "Queixa de dor de cabeça intensa e febre moderada.",
                responsavelRegistro: "Enfermeira Ana",
                sintoma: "Febre e dor de cabeça"));

            service.AdicionarOcorrencia(new OcorrenciaAdministrativa(
                estudanteEnvolvido: "Iago Monteiro Lima",
                data: new DateTime(2026, 5, 31),
                descricao: "Extravio de material escolar em área comum da escola.",
                responsavelRegistro: "Secretaria Escolar",
                setorAfetado: "Secretaria Administrativa"));

            foreach (var ocorrencia in service.ObterTodas())
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Painel de Encaminhamento");
                Console.WriteLine(ocorrencia.ObterDescricaoBase());
                Console.WriteLine($"Setor Responsável: {ocorrencia.IndicarSetorResponsavel()}");
                Console.WriteLine($"Nível de Atenção: {ocorrencia.CalcularNivelAtencao()}");
                Console.WriteLine($"Orientação/Encaminhamento: {ocorrencia.GerarEncaminhamento()}");
                Console.WriteLine();
            }
        }
    }
}
