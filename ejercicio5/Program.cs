using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            cal.marca = "casio";
            cal.valor1 = 6;
            cal.valor2 = 2;

            cal.calcular(tipoOper.suma);

            Console.ReadKey();
        }
    }
}
