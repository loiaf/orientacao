using System;

namespace OcorrenciasEscolares.Domain
{
    public class OcorrenciaAdministrativa : OcorrenciaEscolar
    {
        public string SetorAfetado { get; }

        public OcorrenciaAdministrativa(string estudanteEnvolvido, DateTime data, string descricao, string responsavelRegistro, string setorAfetado)
            : base(estudanteEnvolvido, data, descricao, responsavelRegistro)
        {
            SetorAfetado = string.IsNullOrWhiteSpace(setorAfetado)
                ? throw new ArgumentException("O setor afetado deve ser informado.", nameof(setorAfetado))
                : setorAfetado.Trim();
        }

        public override string CalcularNivelAtencao()
        {
            return "Médio";
        }

        public override string GerarEncaminhamento()
        {
            return "Notificar o setor administrativo responsável e documentar o ocorrido para acompanhamento interno.";
        }

        public override string IndicarSetorResponsavel()
        {
            return SetorAfetado;
        }
    }
}
