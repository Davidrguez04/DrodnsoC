using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoC.Dtos
{
    /// <summary>
    /// David Rodriguez ALonso 04/03/2024
    /// Clase que lleva el objeto Pedido
    /// </summary>
    internal class PedidosDto
    {
        //Atributos
        long id;
        string nombreProducto;
        int cantidadProducto;
        DateTime fechaEntrega;



        //Getters y setters
        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }



        //Constructores
        public PedidosDto(long id, string nombreProducto, int cantidadProducto, DateTime fechaEntrega)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaEntrega = fechaEntrega;
        }



        //C Vacio
        public PedidosDto()
        {
        }

        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "\n\t-----------" +
                "\n\tProducto: " + this.nombreProducto +
                "\n\tCantidad: " + this.cantidadProducto +
                "\n\tFecha Entrega: " + this.fechaEntrega.ToString("dd-M-yyyy");

            return mensaje;
        }
    }
}
