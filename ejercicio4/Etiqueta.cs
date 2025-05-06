using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO4
{
    internal class Etiqueta
    {
        public string apelNom { get; set; }
        public string salon { get; set; }

        public Etiqueta()
        {
            this.apelNom = string.Empty;
            this.salon = string.Empty;
        }

        public Etiqueta(string apelNom, string salon)
        {
            this.apelNom = apelNom;
            this.salon = salon;
        }
    }
}
