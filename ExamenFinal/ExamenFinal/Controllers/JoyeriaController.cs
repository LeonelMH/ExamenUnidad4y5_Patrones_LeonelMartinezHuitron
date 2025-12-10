using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    
    public class JoyeriaController
    {

        private Inventario _inventario;
        private InventarioCaretaker _caretaker;

        private JoyeriaView _vista;

        public JoyeriaController()
        {
            _inventario = new Inventario();
            _caretaker = new InventarioCaretaker();
            _vista = new JoyeriaView();
        }

        public void IniciarProcesoDeCompra()
        {
            _vista.MostrarBienvenida();


            _0JoyeriaInterfazComponent joya = CrearJoyaBase();

            _vista.LimpiarPantalla();
            _vista.MostrarDetalleJoya(joya.Descripcion);

            
            _inventario.AgregarJoyeria(joya);
            _caretaker.Guardar(_inventario);

            
            joya = ProcesoPersonalizacion(joya);


            joya = ProcesoBonificaciones(joya);

            
            _vista.LimpiarPantalla();
            _vista.MostrarResumen(joya.Descripcion, joya.Costo);

            
            _caretaker.Deshacer(_inventario);
            Console.WriteLine("\n(Sistema: Inventario restaurado por Memento)");
            _inventario.MostrarInventario();
            _vista.Pausa();

        }

        private _0JoyeriaInterfazComponent CrearJoyaBase()
        {
            _vista.MostrarMenuJoyas();
            string tipo = _vista.ObtenerEntrada();
            _vista.LimpiarPantalla();

            _vista.MostrarMenuMateriales();
            string materialOp = _vista.ObtenerEntrada();

            IJoyeriaFactory factory = null;
            switch (materialOp)
            {
                case "1": 
                    factory = new OroFactory(); 
                    break;
                case "2": 
                    factory = new PlataFactory(); 
                    break;
                case "3": 
                    factory = new PlatinoFactory(); 
                    break;
                default: factory = new OroFactory(); break;
            }

            switch (tipo)
            {
                case "1": 
                    return factory.CrearAnillo();
                case "2": 
                    return factory.CrearAretes();
                case "3": 
                    return factory.CrearCollar();
                case "4": 
                    return factory.CrearPulsera();
                default: 
                    return factory.CrearAnillo();
            }
        }

        private _0JoyeriaInterfazComponent ProcesoPersonalizacion(_0JoyeriaInterfazComponent joya)
        {
            string op = _vista.ObtenerEntrada("\n¿Deseas personalizar tu JOYA? (1. Sí / 2. No)");
            if (op != "1") 
                return joya;

            bool personalizando = true;
            while (personalizando)
            {
                _vista.LimpiarPantalla();
                _vista.MostrarDetalleJoya(joya.Descripcion);
                _vista.MostrarMenuPersonalizacion();

                op = _vista.ObtenerEntrada();
                switch (op)
                {
                    case "1": 
                        joya = new _3EstucheDecorador(joya); 
                        break;
                    case "2": 
                        joya = new _3GrabadoDecorador(joya); 
                        break;
                    case "3": 
                        joya = new _3SeguroDecorador(joya); 
                        break;
                    case "4": 
                        personalizando = false; 
                        break;
                }
            }

            op = _vista.ObtenerEntrada("¿Envío a domicilio? (1. Sí / 2. No)");
            if (op == "1") 
                joya = new _3EnvioDecorador(joya);

            return joya;
        }

        private _0JoyeriaInterfazComponent ProcesoBonificaciones(_0JoyeriaInterfazComponent joya)
        {
            _vista.LimpiarPantalla();
            Console.WriteLine("--- SECCIÓN DE BONIFICACIONES ---\n");

            string op = _vista.ObtenerEntrada("¿Deseas aplicar bonificación extra por tipo de material? (1. Sí / 2. No)");
            if (op == "1")
            {
                string material = _vista.ObtenerEntrada("Ingresa el material para validar bonificación (Plata, Platino, Oro):");
                joya = new _4BonificacionMaterial(joya, material);
                Console.WriteLine("-> Bonificación de material aplicada.");
            }

            op = _vista.ObtenerEntrada("\n¿Estamos en temporada de ofertas? (1. Sí / 2. No)");
            if (op == "1")
            {
                string temporada = _vista.ObtenerEntrada("Ingresa la temporada (Navidad, San Valentín, Verano):");
                joya = new _4BonificacionTemporada(joya, temporada);
                Console.WriteLine("-> Bonificación de temporada aplicada.");
            }

            string cantidadStr = _vista.ObtenerEntrada("\n¿Cuántas piezas iguales deseas llevar?");

            int cantidad = 1;
            if (!int.TryParse(cantidadStr, out cantidad))
            {
                cantidad = 1; 
                Console.WriteLine("(Entrada inválida, se calculará 1 pieza)");
            }

            joya = new _4BonificacionCantidad(joya, cantidad);

            return joya;
        }
    }
}
