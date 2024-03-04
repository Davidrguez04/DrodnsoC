using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoC.Servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 04/03/2024
    /// Clase usada para los métodos del menu de nuestra app
    /// </summary>
    internal class ImplMenu:InterfazMenu
    {
        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método de menú principal de empleado o gerencia
        /// </summary>
        public int mostrarMenu()
        {
            int opcion = 0;
            Console.WriteLine("\n\tMenú principal");
            Console.WriteLine("\n\t1.-Menú empleado");
            Console.WriteLine("\n\t2.-Menú gerencia");
            Console.WriteLine("\n\t0.-Salir");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;

            Console.WriteLine("\n\t");
            Console.WriteLine("\n\t");
        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método con las opciones en la parte de empleados
        /// </summary>
        public int menuEmpleado()
        {
            int opcion = 0;
            Console.WriteLine("\n\tMenú Empleado");
            Console.WriteLine("\n\t1.-Cálculo total de ventas diario.");
            Console.WriteLine("\n\t2.-Añadir venta.");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método con las opciones en la parte de gerencia
        /// </summary>
        public int menuGerencia()
        {
            int opcion = 0;
            Console.WriteLine("\n\tMenú Gerencia");
            Console.WriteLine("\n\t1.-Escribir en un fichero todas las ventas del día.");
            Console.WriteLine("\n\t2.-Crear un nuevo pedido para proveedores.");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

    }
}
