using System;

namespace ExercicioResolvidoSet.Entities
{
    internal class RegistroDeLog
    {
        public string NomeDeUsuario { get; set; }
        public DateTime Momento { get; set; }

        public override int GetHashCode()
        {
            return NomeDeUsuario.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RegistroDeLog))
            {
                return false;
            }
            RegistroDeLog outro = obj as RegistroDeLog;
            return NomeDeUsuario.Equals(outro.NomeDeUsuario);
        }
    }
}
