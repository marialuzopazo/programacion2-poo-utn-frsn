using System;

namespace EjerPOO8
{
    internal class BatidoraDeMano: IBatidora
    {
        public int CantCuchillas { get; set;}

        public BatidoraDeMano()
        {
            this.CantCuchillas = 0;
        }

        public void Batir()
        {
            throw new NotImplementedException();
        }
    }
}
