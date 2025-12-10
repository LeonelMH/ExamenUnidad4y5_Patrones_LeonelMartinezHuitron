using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class InventarioMemento
    {
        public List<JoyeriaSnapshot> EstadoInventario { get; private set; }

        public InventarioMemento(List<_0JoyeriaInterfazComponent> joyas)
        {
            EstadoInventario = joyas.Select(j =>
                new JoyeriaSnapshot(j.Descripcion, j.Costo, j.Material)).ToList();
        }
    }
}
