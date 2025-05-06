using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1Bis
{
    internal class Humano
    {
        private string _apellido;
        private int _edad;
        private string _direccion;

        public Humano()
        {
            this.apellido = "Garcia";
            this.edad = 20;
            this.direccion = string.Empty;
        }

        public Humano (string ape, int ed, string dir)
        {
            this.apellido = ape;
            this.edad = ed;
            this.direccion = dir;
        }

        public Humano(string ape, int ed)
        {
            this.apellido = ape;
            this.edad = ed;
            this.direccion = string.Empty;
        }

        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int edad
        {
            get { return this._edad; }
            set {
                if (value >= 0 && value < 150)
                {
                    this._edad = value;
                }
            }
        }

        public string direccion
        {
            get { return this._direccion;}
            set { this._direccion = value; }
        }
    }
}
