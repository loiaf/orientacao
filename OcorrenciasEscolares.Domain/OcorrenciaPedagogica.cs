using System;

namespace OcorrenciasEscolares.Domain
{
    public class OcorrenciaPedagogica : OcorrenciaEscolar
    {
        public string DisciplinaAssociada { get; }

        public OcorrenciaPedagogica(string estudanteEnvolvido, DateTime data, string descricao, string responsavelRegistro, string disciplinaAssociada)
            : base(estudanteEnvolvido, data, descricao, responsavelRegistro)
        {
            DisciplinaAssociada = string.IsNullOrWhiteSpace(disciplinaAssociada)
                ? throw new ArgumentException("A disciplina associada deve ser informada.", nameof(disciplinaAssociada))
                : disciplinaAssociada.Trim();
        }

        public override string CalcularNivelAtencao()
        {
            return "Médio";
        }

        public override string GerarEncaminhamento()
        {
            return "Encaminhar para acompanhamento pedagógico e elaborar plano de apoio específico para a disciplina informada.";
        }

        public override string IndicarSetorResponsavel()
        {
            return "Orientação Educacional";
        }
    }
}
