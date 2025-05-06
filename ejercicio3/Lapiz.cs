using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO3
{
    public enum dureza
    {
        H2,
        H,
        B,
        HB,
        B2
    }

    internal class Lapiz
    {

        private string _marca;
        private dureza _tipoMina;
        private string _color;

        public Lapiz()
        { 
            this.marca = string.Empty;
            this.tipoMina = dureza.H;
            this.color = string.Empty;
        }

        public Lapiz(string marca, dureza tipoMina, string color)
        {
            this.marca = marca;
            this.tipoMina = tipoMina;
            this.color = color;
        }

        public string marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }

        public dureza tipoMina
        {
            get { return this._tipoMina; }
            set { this._tipoMina = value; }
        }
        public string color
        {
            get { return this._color; }
            set { this._color = value; }
        }
    }
}
