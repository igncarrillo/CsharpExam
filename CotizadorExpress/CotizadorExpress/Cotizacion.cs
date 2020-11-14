using System;

namespace CotizadorExpress
{
    public class Cotizacion
    {
        public string NumeroIdentificacion { get; }
        public DateTime FechaHora { get; }
        public Vendedor VendedorAsociado { get; }
        private string prendaCotizada;
        private int cantidadUnidades;
        private int resultadoCotizacion;
        
        public Cotizacion(Vendedor vendedor)
        {
            VendedorAsociado = vendedor;
            FechaHora = DateTime.Now;
            NumeroIdentificacion = Program.Randomizador.rnd.Next(0, 10000).ToString();
        }
    }
}