using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoC.Servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 04/03/2024
    /// Interfaz que controla el menu de la app
    /// </summary>
    internal interface InterfazMenu
    {
        //Métodos de la implementación puestos en la interfaz
        public int mostrarMenu();


        public int menuEmpleado();


        public int menuGerencia();
    }
}
