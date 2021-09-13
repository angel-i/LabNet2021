using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3;

namespace tp3_excep_em_test
{
    public class Exceptions 
    {
        int resultdivision = 0;
        public void Dividir_ej1(int a, int b)
        {

            try
            {
                 resultdivision = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("no podes dividir por cero");

            }
            catch (Exception ex)
            {
                Console.WriteLine("excepcion general");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("pasamos x el finally");
            }
            MostrarResultado_ej1();


        }
        public void MostrarResultado_ej1()
        {
            Console.WriteLine("el resultado de la division es " + resultdivision);
        }

        string ingreso1;
        string ingreso2;
        int resultdivision2;
        public void Dividir_ej2(int a, int b)
        {
            //bool continua = true;
            //do
            //{
                try
                {
                    IngresoDatos_ej2();
                    a = Int32.Parse(ingreso1);
                    b = Int32.Parse(ingreso2);
                    resultdivision2 = a / b;
                    mostrarResultado_ej2();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("no podes dividir por cero BURRO!");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ingresame numeros nomá");
                    Console.WriteLine(e.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("excepcion general");
                    Console.WriteLine(ex.Message);
                }
            //} while (continua);

        }
        public void IngresoDatos_ej2()
        {
            Console.WriteLine("ingresa el numerador");
            ingreso1 = Console.ReadLine();
            Console.WriteLine("ingresa el denominador");
            ingreso2 = Console.ReadLine();

        }
        public void mostrarResultado_ej2()
        {
            Console.WriteLine("el resultado de la division es " + resultdivision2);
        }
       
        public void MostrarMensaje_ej3()
        {

            try
            {
                StreamWriter sw = new StreamWriter("");
            }
            catch (System.ArgumentException sae)
            {
                Console.WriteLine(sae.Message);
                Console.WriteLine("tiro excepcion del tipo " + "SystemArgumentException");

            }

        }
        public void MostrarMensaje_ej4()
        {

            try
            {
                if (mostrarnombre_ej4("angel"))
                {
                    ThrowCustomException_ej4();
                }


            }
            catch (CustomException ex)
            {

                Console.WriteLine($"se capturo la custom excepcion '{ex.Message}' ");

            }



        }
        public void ThrowCustomException_ej4()
        {
            throw new CustomException();
        }

        public bool mostrarnombre_ej4(string nombre)
        {

            return true;
        }


        bool result;
        public void ej_ext_meth()
        {
            int i = 10;
            
            result = i.IsGreaterThan(50);
            mostrarResult_em();
        }
        
        public void mostrarResult_em()
        {
            Console.WriteLine(result);
        }

      
    }
}
