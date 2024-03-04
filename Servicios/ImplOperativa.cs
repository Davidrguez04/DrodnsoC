using DrodnsoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoC.Servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 04/03/2024
    /// Clase para la operativa de la app, los métodos necesarios 
    /// </summary>
    internal class ImplOperativa:InterfazOperativa
    {
        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método para añadir una nueva venta
        /// </summary>
        public void nuevaVenta(List<VentasDto> listaVentas)
        {
            VentasDto ventas = datosVenta();

            foreach(VentasDto ventasDto in listaVentas)
            {
                
                ventasDto.Id++;
            }

            listaVentas.Add(ventas);

        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método privado que usamos para pedir los datos de las ventas nuevas
        /// </summary>
        private VentasDto datosVenta()
        {
            VentasDto ventas = new VentasDto();
            Console.Write("\n\tIntroduzca el importe de la venta: ");
            ventas.Importe = Convert.ToInt32(Console.ReadLine());

            return ventas;
           
        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método para calcular las ventas totales en un día
        /// </summary>
        public void calculoVentasDia(List<VentasDto> listaVentas)
        {
            VentasDto ventas=new VentasDto();

            Console.Write("\n\tIntroduzca una fecha de un dia(dd-mm-yyyy): ");
            DateTime fechaDia=Convert.ToDateTime(Console.ReadLine());

            foreach(VentasDto ventasDto in listaVentas)
            {
                if (fechaDia.Equals(ventasDto.FechaVenta.Date))
                {
                    
                   for(int i=0; i<listaVentas.Count; i++)
                    {
                        int importeTotal=+ventasDto.Importe+listaVentas[i].Importe;
                        Console.WriteLine(importeTotal);
                        
                    }

                }

            }


        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método para mostrar las ventas de un día específico
        /// </summary>
        public void mostrarVentas(List<VentasDto> listaVentas)
        {
            VentasDto ventas = new VentasDto();

            Console.Write("\n\tIntroduzca una fecha de un dia(dd-mm-yyyy): ");
            DateTime fechaDia = Convert.ToDateTime(Console.ReadLine());

            foreach(VentasDto ventasDto in listaVentas)
            {
                ventas = ventasDto;
                
                if (fechaDia.Equals(ventasDto.FechaVenta.Date))
                {
                   

                    Console.WriteLine("\n\t------------");
                        Console.WriteLine("\n\tVenta Número: " + ventasDto.Id);
                        Console.WriteLine("\n\tEuros: " + ventasDto.Importe);
                        Console.WriteLine("\n\tInstante de compra: " + ventasDto.FechaVenta);
                   

                }

            }


        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método para crear nuevos pedidos y añadirlos a la lista
        /// </summary>
        public void crearPedido(List<PedidosDto>listaPedidos)
        {
            PedidosDto pedidos = datosPedidos();

            foreach(PedidosDto pedidosDto in listaPedidos)
            {
                pedidosDto.Id++;
            }

            listaPedidos.Add(pedidos);
        }

        /// <summary>
        /// David Rodriguez Alonso - 04/03/2024
        /// Método privado para pedir los datos de los nuevos pedidos
        /// </summary>
        private PedidosDto datosPedidos()
        {
            PedidosDto pedidos = new PedidosDto();

            Console.Write("\n\tIntroduzca el nombre del producto: ");
            pedidos.NombreProducto = Console.ReadLine();

            Console.Write("\n\tCantidad del producto: ");
            pedidos.CantidadProducto=Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tFecha de entrega deseada(dd-mm-yyyy): ");
            pedidos.FechaEntrega=Convert.ToDateTime(Console.ReadLine());

            return pedidos;
        }


    }
}
