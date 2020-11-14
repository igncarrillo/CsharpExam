using System;
using System.Collections.Generic;

namespace CotizadorExpress
{
    public class Vendedor
    {
        public string Nombre { get;}
        public string Apellido { get;}
        public string CodigoVendedor { get; }
        
        private List<Cotizacion> historialVendedor;
        private TiendaDeRopa Tienda { get;}

        public Vendedor(string nombre, string apellido, TiendaDeRopa tienda)
        {
            historialVendedor = new List<Cotizacion>();
            Nombre = nombre;
            Apellido = apellido;
            CodigoVendedor = Program.Randomizador.rnd.Next(0, 1000).ToString();
            Tienda = tienda;
        }

        public void RealizarCotizacion()
        {
            historialVendedor.Add(new Cotizacion(this));
        }
    }
    
}