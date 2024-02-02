using AtividadePOO12.Entities;

namespace AtividadePOO12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment Comentario1 = new Comment("Have a nice trip!");

            Comment Comentario2 = new Comment("Wow that's awesome!");

            Post Post1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);

            Post1.AddComment(Comentario1);

            Post1.AddComment(Comentario2);

            Comment Comentario3 = new Comment("Good night");

            Comment Comentario4 = new Comment("May the Force be with you");

            Post Post2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);

            Post2.AddComment(Comentario3);

            Post2.AddComment(Comentario4);

            Console.WriteLine(Post1);
            Console.WriteLine(Post2);
        }
    }
}
