namespace EjerPOO7
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

        // Propiedad abstracta: debe ser implementada por las clases hijas
        public abstract int perimetro { get; }

        public abstract int superficie { get; }

        // Propiedad con acceso normal (no abstracta)
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

        // Método virtual que puede ser sobreescrito
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Color: {this.colorRelleno}");
            Console.WriteLine($"Posicion: {this.posicion.ToString()}");
        }
    }
}

