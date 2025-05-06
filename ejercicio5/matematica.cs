using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO5
{
    internal class matematica
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }

        public int restar(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public int dividir(int a, int b)
        {
            if (b == 0)
                throw new Exception("Imposible dividir por cero");
            else
                return a / b;
        }

    }
}
