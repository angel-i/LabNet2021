using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Perro : IAnimal
    {
        string sonidoperro;
        public void Sonido()
        {
            sonidoperro = "El perro ladra";
            mostrarSonido();
        }
        public void mostrarSonido()
        {
            Console.WriteLine(sonidoperro);
        }
    }
}
