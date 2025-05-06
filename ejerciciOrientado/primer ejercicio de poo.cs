using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1Bis
{
    internal class Cuadrado
    {
        // 🛡️ Atributos encapsulados
        private string _color;
        private int _lado;

        // 🧱 Constructor por defecto
        public Cuadrado()
        {
            this.color = "Blanco";
            this.lado = 10;
        }

        // 🧱 Constructor con parámetros
        public Cuadrado(string col, int lad)
        {
            this.color = col;
            this.lado = lad;
        }

        // 🌈 Propiedad con validación de color
        public string color
        {
            get { return this._color; }
            set
            {
                // ✅ Solo se permiten ciertos colores
                if (value == "negro" || value == "blanco" || value == "rojo")
                {
                    this._color = value;
                }
            }
        }

        // 📏 Propiedad con validación del lado (debe ser positivo)
        public int lado
        {
            get { return this._lado; }
            set
            {
                if (value > 0)
                {
                    this._lado = value;
                }
            }
        }
    }
}
