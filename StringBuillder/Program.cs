using ClasseStringBuilder.Entidades;

namespace UsandoStringBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem!");
            Comentario c2 = new Comentario("Uau, que legal!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), "Viajando para Nova Zelândia",
                "Indo visitar esse país maravilhoso", 12);
            p1.AdicionarComentario(c1);
            p1.AdicionarComentario(c2);

            Comentario c3 = new Comentario("Boa noite!");
            Comentario c4 = new Comentario("Seja forte!");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"), "Boa noite pessoal!",
                "Vejo vocês amanhã!", 5);
            p2.AdicionarComentario(c3);
            p2.AdicionarComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}

