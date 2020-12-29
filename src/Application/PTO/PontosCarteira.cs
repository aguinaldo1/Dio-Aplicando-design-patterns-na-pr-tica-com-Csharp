using System;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class PontosCarteira
    {
        public DateTime DataOcorrencia { get; set; }
        public string TotalDePontos { get; set; }
    }
}