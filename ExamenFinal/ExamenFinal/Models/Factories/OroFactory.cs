using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class OroFactory : IJoyeriaFactory
    {
        public _0JoyeriaInterfazComponent CrearAnillo()
        {
            var joya = new _2Anillo();
            return new _3MaterialDecorador(joya, "Oro");
        }
        public _0JoyeriaInterfazComponent CrearAretes()
        {
            var joya = new _2Aretes();
            return new _3MaterialDecorador(joya, "Oro");
        }
        public _0JoyeriaInterfazComponent CrearCollar()
        {
            var joya = new _2Collar();
            return new _3MaterialDecorador(joya, "Oro");
        }

        public _0JoyeriaInterfazComponent CrearPulsera()
        {
            var joya = new _2Pulsera();
            return new _3MaterialDecorador(joya, "Oro");
        }
    }
}
