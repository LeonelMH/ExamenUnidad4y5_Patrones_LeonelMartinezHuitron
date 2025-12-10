using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public interface IJoyeriaFactory
    {
        _0JoyeriaInterfazComponent CrearAnillo();
        _0JoyeriaInterfazComponent CrearAretes();
        _0JoyeriaInterfazComponent CrearCollar();
        _0JoyeriaInterfazComponent CrearPulsera();
    }
}
