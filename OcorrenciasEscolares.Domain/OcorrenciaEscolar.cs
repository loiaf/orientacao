using System;

namespace OcorrenciasEscolares.Domain
{
    public abstract class OcorrenciaEscolar
    {
        public string EstudanteEnvolvido { get; }
        public DateTime Data { get; }
        public string Descricao { get; }
        public string ResponsavelRegistro { get; }

        protected OcorrenciaEscolar(string estudanteEnvolvido, DateTime data, string descricao, string responsavelRegistro)
        {
            EstudanteEnvolvido = ValidarTexto(estudanteEnvolvido, nameof(estudanteEnvolvido));
            Data = data == default ? throw new ArgumentException("A data deve ser informada.", nameof(data)) : data;
            Descricao = ValidarTexto(descricao, nameof(descricao));
            ResponsavelRegistro = ValidarTexto(responsavelRegistro, nameof(responsavelRegistro));
        }

        private static string ValidarTexto(string valor, string nome)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException($"O campo '{nome}' não pode ser nulo ou vazio.", nome);
            }

            return valor.Trim();
        }

        public string ObterDescricaoBase()
        {
            return $"[{Data:dd/MM/yyyy}] {EstudanteEnvolvido} - {Descricao} (Registrada por {ResponsavelRegistro})";
        }

        public abstract string GerarEncaminhamento();

        public abstract string CalcularNivelAtencao();

        public abstract string IndicarSetorResponsavel();
    }
}
