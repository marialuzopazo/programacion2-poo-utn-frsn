using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO6
{
    public enum color
    {
        blanco,
        negro,
        azul,
        rojo
    }

    public enum ubicacion
    {
        arriba,
        abajo,
        derecha,
        izquierda,
        centro
    }
    internal abstract class figura
    {
        private color _colorRelleno;
        private ubicacion _posicion;

        public abstract int perimetro{
            get;
        }

        public abstract int superficie
        {
            get;
        }

        public color colorRelleno
        {
            get { return this._colorRelleno; }
            set { this._colorRelleno = value; }
        }

        public ubicacion posicion
        {
            get { return this._posicion; }
            set { this._posicion = value; }
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Color: {this.colorRelleno}");
            Console.WriteLine($"Posicion: {this.posicion.ToString()}");
        }

    }
}
