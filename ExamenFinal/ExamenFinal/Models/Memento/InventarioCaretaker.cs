using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class InventarioCaretaker
    {
        private Stack<InventarioMemento> historial = new Stack<InventarioMemento>();

        public void Guardar(Inventario inventario)
        {
            historial.Push(inventario.GuardarEstado());
        }

        public void Deshacer(Inventario inventario)
        {
            if (historial.Count > 0)
            {
                var memento = historial.Pop();
                inventario.RestaurarEstado(memento);
            }
        }
    }
}
