using System;

namespace ExerTratamentoDeExcecoes.ContaBancaria.Excecoes
{
    internal class Excecao : ApplicationException
    {
        public Excecao(string mensagem) : base(mensagem)
        {
        }
    }
}
