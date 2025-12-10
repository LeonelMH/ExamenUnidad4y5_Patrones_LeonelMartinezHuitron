using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class _3MaterialDecorador : _1JoyaDecorador
    {
        private string material;

        public _3MaterialDecorador(_0JoyeriaInterfazComponent joyas, string material) : base(joyas)
        {
            this.material = material;
        }

        public override string Material => material;

        public override string Descripcion
        {
            get
            {
                double costoFinal = Costo; 
                double costoExtra = costoFinal - _joyas.Costo;

                return _joyas.Descripcion +
                       $"\n (-) Material {material}\t\t\t+${costoExtra}";
            }
        }

        public override double Costo
        {
            get
            {
                if (material == "Oro") return _joyas.Costo * 2;       
                if (material == "Plata") return _joyas.Costo * 1.2;   
                if (material == "Platino") return _joyas.Costo * 1.5; 
                return _joyas.Costo;
            }
        }
    }
}
