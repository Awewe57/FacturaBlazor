using facturablazor.ArFac;
using System;
using System.Collections.Generic;
using System.Linq;

namespace facturablazor.ArFac
{
    public class Factura
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string NombreCliente { get; set; } = "";
        public List<Articulo> Articulos { get; set; } = new List<Articulo>();

        public decimal Total => Articulos.Sum(a => a.Precio);
    }
}
