using TratamentoDeExcecoes.Reservas;
using TratamentoDeExcecoes.Reservas.Excecoes;

namespace TratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Check-in data (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Informe as datas para atualização da reserva:");
                Console.Write("Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reserva.AtualizarDatas(checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }
            catch (Excecao e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}

