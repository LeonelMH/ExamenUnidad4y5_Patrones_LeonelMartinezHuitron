using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class _4BonificacionCantidad : _1JoyaDecorador
    {
        private int _cantidad;
        public _4BonificacionCantidad(_0JoyeriaInterfazComponent joyas, int cantidad) : base(joyas)
        {
            _cantidad = cantidad;
        }
        public override string Descripcion
        {
            get
            {
                if (_cantidad >= 2)
                {
                    return _joyas.Descripcion + $"\n\n + Bonificación por cantidad ({_cantidad} piezas) 10%";
                }
                else
                {
                    return _joyas.Descripcion + $"\n\n - No hay bonificación para ({_cantidad} pieza)";
                }
            }
        }
        public override double Costo
        {
            get
            {
                double precioBase = _joyas.Costo * _cantidad;
                if (_cantidad >= 2)
                    return precioBase * 0.9; 
                return precioBase;

            }
        }
        public override string Material => _joyas.Material;

    }
}
