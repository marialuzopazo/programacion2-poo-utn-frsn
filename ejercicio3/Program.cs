using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lapiz mila = new Lapiz("Faber", dureza.HB,"Rojo");

            Console.WriteLine($"Marca: {mila.marca}");
            Console.WriteLine($"Tipo Mina: {mila.tipoMina}");
            Console.WriteLine($"Color: {mila.color}");

            if (mila.tipoMina == dureza.H2 || mila.tipoMina == dureza.H)
            {
                Console.WriteLine("El lapiz cuenta con una mina dura");
            }
            else
            {
                Console.WriteLine("El lapiz cuenta con una mina blanda");
            }

            Console.ReadKey();

        }
    }
}
