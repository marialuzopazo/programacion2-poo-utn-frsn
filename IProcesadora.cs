using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO8
{
    internal interface IProcesadora
    {
        //no permite generar instancias
        //no permite definir alcance protected
        //no permite definir implementaciones por default (desde c# 8 es posible)

        //permite trabajar con inyeccion de dependencias
        //permite herencia multiple

        //definir un contrato

        void Procesar();

    }
}
