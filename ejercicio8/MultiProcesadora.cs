using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO8
{
    internal class MultiProcesadora : IBatidora, IProcesadora, ILicuadora
    {
        public string Marca { get; set; }
        public int Velocidades { get; set; }

        public int CapacidadRecipiente { get; set; }    

        public MultiProcesadora()
        {
            this.Marca = string.Empty;
            this.Velocidades = 1;
            this.CapacidadRecipiente = 1500;

        }

        public void Batir()
        {
            throw new NotImplementedException();
        }

        public void Procesar()
        {
            throw new NotImplementedException();
        }

        public void Licuar()
        {
            throw new NotImplementedException();
        }
    }
}
