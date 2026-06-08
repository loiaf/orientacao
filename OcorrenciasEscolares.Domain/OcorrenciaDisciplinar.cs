using System;

namespace OcorrenciasEscolares.Domain
{
    public class OcorrenciaDisciplinar : OcorrenciaEscolar
    {
        public string GrauInfracao { get; }

        public OcorrenciaDisciplinar(string estudanteEnvolvido, DateTime data, string descricao, string responsavelRegistro, string grauInfracao)
            : base(estudanteEnvolvido, data, descricao, responsavelRegistro)
        {
            GrauInfracao = string.IsNullOrWhiteSpace(grauInfracao)
                ? throw new ArgumentException("O grau de infração deve ser informado.", nameof(grauInfracao))
                : grauInfracao.Trim();
        }

        public override string CalcularNivelAtencao()
        {
            return GrauInfracao.Contains("grave", StringComparison.OrdinalIgnoreCase)
                ? "Alto"
                : "Médio";
        }

        public override string GerarEncaminhamento()
        {
            return "Registrar na coordenação pedagógica e agendar reunião com a família para definição de medida corretiva.";
        }

        public override string IndicarSetorResponsavel()
        {
            return "Coordenação Pedagógica";
        }
    }
}
