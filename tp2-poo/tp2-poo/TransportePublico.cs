using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_poo
{
    public abstract class TransportePublico
    {
        protected int pasajeros { get; set; }

        protected TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        protected TransportePublico()
        {
        }
        public int getPasajeros()
        {
            return pasajeros;
        }

        //public TransportePublico (int pasajeros)
        //{
        //    this.pasajeros = pasajeros;
        //}



        public abstract string Avanzar();
       
        public abstract string MostrarPasajeros();
    }
}
