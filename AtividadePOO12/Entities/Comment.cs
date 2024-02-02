using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO12.Entities
{
    internal class Comment
    {
        public String Texto { get; set; }

        public Comment(string texto)
        {
            Texto = texto;
        }
    }
}
