using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO7
{
    internal class Rectangulo: figura
    {
        private int _ladoA;
        private int _ladoB;

        public Rectangulo()
        {
            this.colorRelleno = color.blanco;
            this.ladoA = 1;
            this.ladoB = 1;
            this.posicion = ubicacion.centro;
        }

        public Rectangulo(color colorRelleno, int ladoA, int ladoB, ubicacion posicion)
        {
            this.colorRelleno = colorRelleno;
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.posicion = posicion;
        }

        public int ladoA
        {
            get { return this._ladoA; }
            set
            {
                if (value > 0)
                {
                    this._ladoA = value;
                }
            }
        }

        public int ladoB
        {
            get { return this._ladoB; }
            set
            {
                if (value > 0)
                {
                    this._ladoB = value;
                }
            }
        }

        public override int perimetro
        {
            get { return this.ladoA * 2 + this.ladoB * 2; }
        }

        public override int superficie
        {
            get { return this.ladoA * this.ladoB; }
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Color: {this.colorRelleno}");
            Console.WriteLine($"Lado A: {this.ladoA}");
            Console.WriteLine($"Lado B: {this.ladoB}");
            Console.WriteLine($"Posicion: {this.posicion}");
            Console.WriteLine($"Superficie: {this.superficie}");
            Console.WriteLine($"Perimetro: {this.perimetro}");
        }

    }
}
