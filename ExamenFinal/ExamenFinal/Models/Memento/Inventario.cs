using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Inventario
    {
        private List<_0JoyeriaInterfazComponent> joyas = new List<_0JoyeriaInterfazComponent>();

        public void AgregarJoyeria(_0JoyeriaInterfazComponent joya)
        {
            joyas.Add(joya);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario actual:");
            foreach (var joya in joyas)
            {
                Console.WriteLine($"{joya.Descripcion}");
            }
            Console.WriteLine($"\nTOTAL INICIAL: ${CalcularTotal()}");
        }

        public double CalcularTotal()
        {
            return joyas.Sum(j => j.Costo);
        }

        public InventarioMemento GuardarEstado()
        {
            return new InventarioMemento(joyas);
        }

        public void RestaurarEstado(InventarioMemento memento)
        {
            joyas = new List<_0JoyeriaInterfazComponent>(memento.EstadoInventario);
        }
    }
}
