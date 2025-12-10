using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    
    public class JoyeriaView
    {
        public void MostrarBienvenida()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\t\tJOYERIA CHULA VISTA");
            Console.WriteLine("---------------------------------------------------------\n");
        }

        public void MostrarMenuJoyas()
        {
            Console.WriteLine("Selecciona el tipo de joya:");
            Console.WriteLine("1. Anillo\t\t\t$250.00");
            Console.WriteLine("2. Aretes\t\t\t$300.00");
            Console.WriteLine("3. Collar\t\t\t$350.00");
            Console.WriteLine("4. Pulsera\t\t\t$400.00");
        }

        public void MostrarMenuMateriales()
        {
            Console.WriteLine("Selecciona el material:");
            Console.WriteLine("1. Oro\n2. Plata\n3. Platino");
        }

        public void MostrarMenuPersonalizacion()
        {
            Console.WriteLine("\nOpciones de personalización:");
            Console.WriteLine("1. Agregar Estuche Lujoso");
            Console.WriteLine("2. Agregar Grabado");
            Console.WriteLine("3. Agregar Seguro");
            Console.WriteLine("4. Finalizar personalización");
        }

      
        public void MostrarDetalleJoya(string descripcion)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"\tJOYA SELECCIONADA\n{descripcion}");
        }

        public void MostrarResumen(string descripcion, double total)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"---\t\t\tRESUMEN DE TU PEDIDO\t\t\t---");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(descripcion);
            Console.WriteLine($"\nTOTAL A PAGAR\t\t\t${total}");
            Console.WriteLine("\nGracias por tu compra. ¡Vuelve pronto a Joyeria Chula Vista!");
        }

        public string ObtenerEntrada(string mensaje = "")
        {
            if (!string.IsNullOrEmpty(mensaje)) Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        public void LimpiarPantalla() => Console.Clear();
        public void Pausa() => Console.ReadKey();
    }
}
