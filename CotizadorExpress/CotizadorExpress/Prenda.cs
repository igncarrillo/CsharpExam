namespace CotizadorExpress
{
    public class Prenda
    {
        protected enum calidadPrenda { Standard , Premium }
        protected int precioPrenda;
        protected int cantidadEnStock;

    }

    public class Pantalon : Prenda
    {
        private bool esChupin; //F es comun

    }

    public class Camisas : Prenda
    {
        private bool esMangaCorta; //F es manga larga
        private bool cuelloMao;

    }
}