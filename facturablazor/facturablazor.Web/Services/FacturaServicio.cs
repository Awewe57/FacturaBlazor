using facturablazor.ArFac;

namespace facturablazor.Web.Services
{
    public class FacturaServicio
    {
        private List<Factura> _facturas = new List<Factura>();

        public List<Factura> ObtenerFacturas() => _facturas;

        public void AgregarFactura(Factura factura)
        {
            _facturas.Add(factura);
        }
    }
}