using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos_Disponibles
{
    public class Vuelo_Cancelado
    {
        public static bool DevuelveSiVueloEstaCancelado(string Vuelo)
        {

            if (Vuelo == "cancelado")
            {
                return true;
            }
            return false;
        }
    }
}
