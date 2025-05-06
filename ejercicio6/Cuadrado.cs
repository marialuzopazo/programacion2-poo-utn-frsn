using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO6
{
   

    internal class Cuadrado : figura
    {
        private int _ladoA;
                
        public Cuadrado()
        {
            this.colorRelleno = color.blanco;
            this.ladoA = 1;
            this.posicion = ubicacion.centro;
        }

        public Cuadrado(color colorRelleno, int ladoA, ubicacion posicion)
        {
            this.colorRelleno = colorRelleno;
            this.ladoA = ladoA;
            this.posicion = posicion;
        }

        public int ladoA
        {
            get { return this._ladoA; }
            set { 
                if (value > 0)
                {
                    this._ladoA = value;
                } 
            }
        }

        public override int perimetro {
            get { return this.ladoA * 4; }
        }

        public override int superficie
        {
            get { return this.ladoA * this.ladoA; }
        }
       
    }
}
