using System;
using System.Collections.Generic;

namespace OcorrenciasEscolares.Domain
{
    public class OcorrenciaService
    {
        private readonly List<OcorrenciaEscolar> _ocorrencias = new();

        public void AdicionarOcorrencia(OcorrenciaEscolar ocorrencia)
        {
            ArgumentNullException.ThrowIfNull(ocorrencia, nameof(ocorrencia));
            _ocorrencias.Add(ocorrencia);
        }

        public IReadOnlyCollection<OcorrenciaEscolar> ObterTodas()
        {
            return _ocorrencias.AsReadOnly();
        }
    }
}
