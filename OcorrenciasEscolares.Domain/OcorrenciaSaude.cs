using System;

namespace OcorrenciasEscolares.Domain
{
    public class OcorrenciaSaude : OcorrenciaEscolar
    {
        public string Sintoma { get; }

        public OcorrenciaSaude(string estudanteEnvolvido, DateTime data, string descricao, string responsavelRegistro, string sintoma)
            : base(estudanteEnvolvido, data, descricao, responsavelRegistro)
        {
            Sintoma = string.IsNullOrWhiteSpace(sintoma)
                ? throw new ArgumentException("O sintoma deve ser informado.", nameof(sintoma))
                : sintoma.Trim();
        }

        public override string CalcularNivelAtencao()
        {
            return Sintoma.Contains("febre", StringComparison.OrdinalIgnoreCase) || Sintoma.Contains("desmaio", StringComparison.OrdinalIgnoreCase)
                ? "Alto"
                : "Médio";
        }

        public override string GerarEncaminhamento()
        {
            return "Levar o estudante à enfermaria e monitorar a evolução antes de liberar para retorno às atividades.";
        }

        public override string IndicarSetorResponsavel()
        {
            return "Enfermaria";
        }
    }
}
