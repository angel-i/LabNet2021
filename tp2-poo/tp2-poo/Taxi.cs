using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_poo
{
    class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
        }

      


        public override string Avanzar()
        {
            return $"hago viajes dentro del pais";
        }

       

        public override string MostrarPasajeros()
        {
            return $"llevo {getPasajeros()} pasajeros";
        }
    }
}
