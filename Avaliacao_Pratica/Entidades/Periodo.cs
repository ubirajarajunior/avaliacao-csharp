using System;
namespace Avaliacao_Pratica.Entidades
{
    class Periodo
    {
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }

        public Periodo(DateTime dataFim, DateTime dataInicio)
        {
            DataFim = dataFim;
            DataInicio = dataInicio;
        }
    }
}
