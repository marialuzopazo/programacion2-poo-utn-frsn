using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BatidoraDeMano bati = new BatidoraDeMano();
            bati.CantCuchillas = 3;

            Console.WriteLine($"Cuchillas: {bati.CantCuchillas}");
            //bati.Batir();

            MultiProcesadora multi = new MultiProcesadora();
            
            Console.ReadKey();
        }
    }
}
