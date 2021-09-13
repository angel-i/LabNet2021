using System;
using tp3_excep_em_test;

namespace TP3
{
    class Program 
    {
        
        
        static void Main(string[] args)
        {
      
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            Automovil auto1 = new Automovil();
            Console.WriteLine(auto1.Avanzar());
        }
       
        private static bool MainMenu()
        {
            Exceptions exceptions = new Exceptions();
            Perro p1 = new Perro();

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Ejercicio 1");
            Console.WriteLine("2) Ejercicio 2");
            Console.WriteLine("3) Ejercicio 3");
            Console.WriteLine("4) Ejercicio 4");
            Console.WriteLine("5) ExtensionMethod");
            Console.WriteLine("6) Mostrar Sonido");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    exceptions.Dividir_ej1(10, 0);
                    Console.Read();
                    return true;
                case "2":
                    exceptions.Dividir_ej2(10,0);
                    Console.Read();
                    return true;
                case "3":
                    exceptions.MostrarMensaje_ej3();
                    Console.Read();
                    return true;
                case "4":
                    exceptions.MostrarMensaje_ej4();
                    Console.Read();
                    return true;
                case "5":
                    exceptions.ej_ext_meth();
                    Console.Read();
                    return true;
                case "6":
                    p1.Sonido();
                    Console.Read();
                    return true;
                case "7":
                    return false;
            
                default:
                    return true;
                    
                    
            }
           
        }

        
    }
}
