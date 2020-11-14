using System.Collections.Generic;

namespace CotizadorExpress
{
    public class TiendaDeRopa
    {
        public string Nombre { get; }
        public string Direccion { get; }
        public List<Vendedor> Vendedores { get;}
        
        private List<Prenda> prendasParaVender { get;}

        public TiendaDeRopa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void AgregarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }
        
        
    }
}