using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoC.Dtos
{
    /// <summary>
    /// David Rodriguez ALonso 04/03/2024
    /// Clase que lleva el objeto Ventas
    /// </summary>
    internal class VentasDto
    {
        //Atributos
        long id=1;
        int importe;
        DateTime fechaVenta= DateTime.Now;
        TimeSpan diferencia;

        //Getters y setters
        public long Id { get => id; set => id = value; }
        public int Importe { get => importe; set => importe = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public TimeSpan Diferencia { get => diferencia; set => diferencia = value; }


        //Constructores
        public VentasDto(long id, int importe, DateTime fechaVenta, TimeSpan diferencia)
        {
            this.id = id;
            this.importe = importe;
            this.fechaVenta = fechaVenta;
            this.diferencia = diferencia;
        }

        //C Vacio
        public VentasDto()
        {
        }


        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "\n\t-----------" +
                "\n\tVenta Numero: "+this.Id+
                "\n\tEuros: "+this.importe+
                "\n\tInstante de compra: "+this.fechaVenta.ToString("dd-M-yyyy h:m:s");

                return mensaje;
        }
    }
}
