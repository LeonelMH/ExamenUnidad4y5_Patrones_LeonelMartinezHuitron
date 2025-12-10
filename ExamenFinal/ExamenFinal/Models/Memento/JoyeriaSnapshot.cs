using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class JoyeriaSnapshot : _0JoyeriaInterfazComponent
    {
        public override string Descripcion { get; }
        public override double Costo { get; }
        public override string Material { get; }
        public JoyeriaSnapshot(string descripcion, double costo, string material)
        {
            Descripcion = descripcion;
            Costo = costo;
            Material = material;
        }
    }
}
