using TratamentoDeExcecoes.Reservas.Excecoes;

namespace TratamentoDeExcecoes.Reservas
{
    internal class Reserva
    {
        public int NumeroDoQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {
        }

        public Reserva(int numeroDoQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new Excecao("A data de CheckOut deve ser posterior a data de CheckIn.");
            }
            
            NumeroDoQuarto = numeroDoQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public double Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return duracao.TotalDays;
        }

        public void AtualizarDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime dataAtual = DateTime.Now;
            if (checkIn < dataAtual || checkOut < dataAtual)
            {
                throw new Excecao("Você deve informar datas futuras para atualizar a reserva!");
            }
            if (checkOut <= checkIn)
            {
                throw new Excecao("A data de CheckOut deve ser posterior a data de CheckIn.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Quarto "
                + NumeroDoQuarto
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + " noites";
        }
    }
}
