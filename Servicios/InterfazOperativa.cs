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
    /// Interfaz para la operativa de la app
    /// </summary>
    internal interface InterfazOperativa
    {
        //Métodos de la implementación puestos en la interfaz
        public void nuevaVenta(List<VentasDto> listaVentas);

        public void calculoVentasDia(List<VentasDto> listaVentas);


        public void mostrarVentas(List<VentasDto> listaVentas);

        public void crearPedido(List<PedidosDto> listaPedidos);


    }
}
