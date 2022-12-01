namespace ExerEnumComposicao.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataAniversario)
        {
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
        }

        public override string ToString()
        {
            return Nome
                + ", ("
                + DataAniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
