using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_poo
{
    class Program
    {
        
    
        static void Main(string[] args)
        {
          

            

            List<TransportePublico> transportes = new List<TransportePublico>();

           
          
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("ingrese cant de pasajeros para el taxi nro" + (i+1));
                transportes.Add(new Taxi(int.Parse(Console.ReadLine())));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese cant de pasajeros para el omnibus nro" + (i + 1));
                transportes.Add(new Omnibus(int.Parse(Console.ReadLine())));
            }




            foreach (var item in transportes)
            {
                if (transportes.IndexOf(item) < 5)
                {
                    Console.WriteLine("Taxi " + (transportes.IndexOf(item) + 1) + ": " + item.MostrarPasajeros());
                }
                else
                {
                    if (transportes.IndexOf(item) == 5)
                    {
                        Console.WriteLine("");
                    }

                    Console.WriteLine("Omnibus " + (transportes.IndexOf(item) - 4) + ": " + item.MostrarPasajeros());

                }
            }

            

            Taxi taxi1 = new Taxi(3);
            Console.WriteLine(taxi1.Avanzar());
            Omnibus omnibus1 = new Omnibus(3);
            Console.WriteLine(omnibus1.Avanzar());
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.ReadLine();
        }
    }
}
