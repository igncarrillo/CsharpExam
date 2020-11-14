using System;

namespace CotizadorExpress
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor("Ignacio","Carrillo");
            vendedor.RealizarCotizacion();
        }
        
        public static class Randomizador
        {
            public static Random rnd = new Random();
        }
    }
    
    
}