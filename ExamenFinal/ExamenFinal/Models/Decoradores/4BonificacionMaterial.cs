using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class _4BonificacionMaterial : _1JoyaDecorador
    {
        private string material;

        public _4BonificacionMaterial(_0JoyeriaInterfazComponent joyas, string material) : base(joyas)
        {
            this.material = material;
        }

        public override string Material => material;

        public override string Descripcion
        {
            get
            {
                string detalle = material == "Plata" ? "5%" :
                                 material == "Platino" ? "8%" : "0%";
                return _joyas.Descripcion + $"\n (-) Bonificación por material ({material}) {detalle}";
            }
        }

        public override double Costo
        {
            get
            {
                double descuento = material == "Plata" ? 0.05 :
                                   material == "Platino" ? 0.08 : 0.0;
                return _joyas.Costo * (1 - descuento);
            }
        }
    }
}
