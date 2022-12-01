using System.Text;

namespace ClasseStringBuilder.Entidades
{
    internal class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int curtidas)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtidas = curtidas;
        }

        public void AdicionarComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");
            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }   
}
