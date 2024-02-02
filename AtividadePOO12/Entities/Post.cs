using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadePOO12.Entities;

namespace AtividadePOO12.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append(" Likes - ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine(Content);
            stringBuilder.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                stringBuilder.AppendLine(c.Texto);
            }
            return stringBuilder.ToString();
        }
    }
}
