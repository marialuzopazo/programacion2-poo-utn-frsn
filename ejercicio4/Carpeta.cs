using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO4
{
    public enum color
    { 
        blanco,
        negro,
        rojo,
        azul
    }
    internal class Carpeta
    {
        private string _materia;
        private bool _esAnillada;
        private color _colorTapa;
        private Etiqueta _etiqueta;

        public Carpeta()
        {
            this.materia = string.Empty;
            this.esAnillada = false;
            this.colorTapa = color.blanco;
            this.etiqueta = new Etiqueta();
        }

        public Carpeta(string materia, bool esAnillada, color colorTapa)
        {
            this.materia = materia;
            this.esAnillada = esAnillada;
            this.colorTapa = colorTapa;
            this.etiqueta = new Etiqueta();
        }

        public Carpeta(string materia, bool esAnillada, color colorTapa, Etiqueta etiqueta)
        {
            this.materia = materia;
            this.esAnillada = esAnillada;
            this.colorTapa = colorTapa;
            this.etiqueta = etiqueta;
        }


        public string materia 
        { 
            get { return this._materia;}
            set { this._materia = value;} 
        }

        public bool esAnillada
        {
            get { return this._esAnillada; }
            set { this._esAnillada = value; }
        }

        public color colorTapa
        {
            get { return this._colorTapa; }
            set { this._colorTapa = value; }
        }

        public Etiqueta etiqueta
        {
            get { return this._etiqueta; }
            set { this._etiqueta = value;}    
        }
    }
}
