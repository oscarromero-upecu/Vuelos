using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos_Disponibles
{
    public  class Vuelos_lleno
    {
        public static bool DevuelveSiVueloEstaLleno(string Vuelo)
        {

            if (Vuelo != null)
            {
                return true;
            }
            return false;
        }
    }
}
