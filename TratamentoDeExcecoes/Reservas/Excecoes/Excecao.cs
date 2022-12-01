namespace TratamentoDeExcecoes.Reservas.Excecoes
{
    internal class Excecao : ApplicationException
    {
        public Excecao(string mensagem) : base(mensagem)
        {
        }
    }
}
