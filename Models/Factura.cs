using System;

namespace ComercioArtes.Models
{
    // Clase Factura, representa la factura de una compra
    public class Factura
    {
        // Datos de la factura
        public int Id { get; set; }
        public DateTime Fecha { get; set; }    // fecha y hora en que se emitió
        public int IdComprador { get; set; }   // comprador al que pertenece la factura
        public decimal Total { get; set; }     // monto total de la compra
        public EstadoFactura Estado { get; set; }

        // Constructor vacío, la fecha se pone sola y la factura empieza como emitida
        public Factura()
        {
            Fecha  = DateTime.Now;
            Estado = EstadoFactura.Emitida;
        }

        // Constructor con los datos principales, la fecha y el estado se asignan solos
        public Factura(int id, int idComprador, decimal total)
        {
            Id           = id;
            IdComprador  = idComprador;
            Total        = total;
            Fecha        = DateTime.Now;
            Estado       = EstadoFactura.Emitida;
        }
    }
}
