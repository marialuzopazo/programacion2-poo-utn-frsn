namespace EjerPOO7
{
    internal class Rectangulo: figura // Hereda de figura
    {
        private int _ladoA;
        private int _ladoB;

        public Rectangulo()
        {
            // Constructor por defecto
            this.colorRelleno = color.blanco;
            this.ladoA = 1;
            this.ladoB = 1;
            this.posicion = ubicacion.centro;
        }

        public Rectangulo(color colorRelleno, int ladoA, int ladoB, ubicacion posicion)
        {
            // Constructor personalizado con parámetros
            this.colorRelleno = colorRelleno;
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.posicion = posicion;
        }

        // Propiedad pública con validación
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

        // Implementación de propiedad abstracta: Perímetro
        public override int perimetro
        {
            get { return this.ladoA * 2 + this.ladoB * 2; }
        }

        // Implementación de propiedad abstracta: Superficie
        public override int superficie
        {
            get { return this.ladoA * this.ladoB; }
        }

        // Método para mostrar datos específicos del rectángulo
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
