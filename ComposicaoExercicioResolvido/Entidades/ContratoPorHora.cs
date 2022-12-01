using System;

namespace ComposicaoExercicioResolvido.Entidades
{
    internal class ContratoPorHora
    {
        public DateTime Data { get; set; }
        public Double ValorPorHoras { get; set; }
        public int Horas { get; set; }

        public ContratoPorHora()
        {
        }
        public ContratoPorHora(DateTime data, double valorPorHoras, int horas)
        {
            Data = data;
            ValorPorHoras = valorPorHoras;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return Horas * ValorPorHoras;
        }
    }
}
