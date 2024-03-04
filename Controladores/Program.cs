

using DrodnsoC.Dtos;
using DrodnsoC.Servicios;

namespace DrodnsoC.Controladores
{
    /// <summary>
    /// David Rodriguez Alonso - 04/03/2024
    /// Clase que controla el flujo de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método que controla los procedimientos de la aplicación y la entrada
        /// </summary>
        static void Main(string[] args)
        {
            InterfazMenu ni = new ImplMenu();
            InterfazOperativa mi=new ImplOperativa();

            VentasDto ventas= new VentasDto();
            PedidosDto pedidos= new PedidosDto();

            List<VentasDto> listaVentas = new List<VentasDto>();
            List<PedidosDto> listaPedidos=new List<PedidosDto>();
            

            bool salirMenu = false;

            while(!salirMenu)
            {
                Console.WriteLine();
                int opcionSeleccionada = ni.mostrarMenu();

                if(opcionSeleccionada==1 )
                {
                    int opcionEmpleado = ni.menuEmpleado();

                    switch( opcionEmpleado)
                    {
                        case 1:
                            mi.calculoVentasDia(listaVentas);
                            break;

                        case 2:
                            mi.nuevaVenta(listaVentas);
                            break;

                        default:
                            Console.WriteLine("\n\tERROR---Opción seleccionada incorrecta!!!!");
                            break;

                    }

                }

                else if( opcionSeleccionada==2)
                {
                    int opcionGerencia=ni.menuGerencia();

                    switch (opcionGerencia)
                    {
                        case 1:
                            mi.mostrarVentas(listaVentas);

                            string rutaFicheroo = ventas.FechaVenta.Day+ventas.FechaVenta.Month+ventas.FechaVenta.Year+".txt";
                            StreamWriter sw=new StreamWriter(rutaFicheroo);

                            foreach (VentasDto ventasDto in listaVentas)
                            {
                                sw.WriteLine(ventasDto.ToString());
                            }

                            sw.Close();
                            break;

                        case 2:
                            bool salir = false;
                            while (!salir)
                            {
                                mi.crearPedido(listaPedidos);
                                Console.Write("\n\tQuiere seguir creando mas pedidos?(S|N): ");
                                string respuesta = Console.ReadLine();
                                if (respuesta == "S")
                                {
                                    Console.WriteLine("\n\tPerfecto nuevo pedido:");
                                }
                                else if (respuesta == "N")
                                {
                                    foreach(PedidosDto pedidosDto in listaPedidos)
                                    {
                                        Console.WriteLine(pedidosDto.ToString());
                                        
                                    }

                                    salir = true;
                                }
                                else
                                {
                                    Console.WriteLine("\n\tERROR--- Respuesta incorrecta");
                                }
                            }
                            
                            break;

                        default:
                            Console.WriteLine("\n\tERROR---Opción seleccionada incorrecta!!!!");
                            break;

                    }
                }

                else if (opcionSeleccionada == 0)
                {
                    Console.WriteLine("\n\tHa pulsado la opción salir, muchas gracias por usar nuestro programa!!");
                    salirMenu = true;
                }

                else
                {
                    Console.WriteLine("\n\tERROR---Opción seleccionada incorrecta!!!!");
                }
            }




        }

    }
}
