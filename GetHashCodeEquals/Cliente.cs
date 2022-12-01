namespace GetHashCodeEquals
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
            {
                return false;
            }
            Cliente outro = obj as Cliente;
            return Email.Equals(outro.Email);            
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
