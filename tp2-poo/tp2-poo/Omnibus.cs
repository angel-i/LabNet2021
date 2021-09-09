using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_poo
{
  public  class Omnibus  :TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {
        }
        public override string Avanzar()
        {
            return $"hago viajes fuera del pais";
        }

      

        public override string MostrarPasajeros()
        {
            return $"llevo {getPasajeros()} pasajeros";
        }
    }
}
