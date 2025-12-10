using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class _4BonificacionTemporada : _1JoyaDecorador
    {
        private string _temporada;
        public _4BonificacionTemporada(_0JoyeriaInterfazComponent joyas, string temporada) : base(joyas)
        {
            _temporada = temporada;
        }
        public override string Descripcion
        {
            get
            {
                string detalle = _temporada == "Navidad" ? "15%" :
                                 _temporada == "San Valentín" ? "10%" :
                                 _temporada == "Verano" ? "5%" :
                                 "0%";
                return _joyas.Descripcion + $"\n\n (+) Bonificación por temporada ({_temporada}) {detalle}";
            }

        }

        public override double Costo
        {
            get
            {
                double descuento = _temporada == "Navidad" ? 0.15 :
                                   _temporada == "San Valentín" ? 0.10 :
                                   _temporada == "Verano" ? 0.05 :
                                   0.0;
                return _joyas.Costo * (1 - descuento);
            }

        }
        public override string Material => _joyas.Material;

    }
}
