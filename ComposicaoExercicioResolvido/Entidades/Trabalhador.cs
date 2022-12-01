using ComposicaoExercicioResolvido.Entidades.Enums;

namespace ComposicaoExercicioResolvido.Entidades
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelDoTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoPorHora> Contratos { get; private set; } = new List<ContratoPorHora>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelDoTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoPorHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoPorHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Rendimento(int year, int month)
        {
            double soma = SalarioBase;
            foreach (ContratoPorHora contrato in Contratos)
            {
                if (contrato.Data.Year == year && contrato.Data.Month == month)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
