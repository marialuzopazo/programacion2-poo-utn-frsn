using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO3
{
    internal class LapizCorto
    {
        public string marca { get; set; }
        public string tipoMina { get; set; }
        public string color { get; set; }

        public LapizCorto()
        {
            this.marca = string.Empty;
            this.tipoMina = string.Empty;
            this.color = string.Empty;
        }

        public LapizCorto(string marca, string tipoMina, string color)
        {
            this.marca = marca;
            this.tipoMina = tipoMina;
            this.color = color;
        }
    }
}
