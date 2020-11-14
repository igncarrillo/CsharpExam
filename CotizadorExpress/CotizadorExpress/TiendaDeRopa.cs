﻿using System;
using System.Collections.Generic;

namespace CotizadorExpress
{
    public class TiendaDeRopa
    {
        public string Nombre { get; }
        public string Direccion { get; }
        private List<Vendedor> Vendedores { get;}
        
        private List<Prenda> prendasParaVender { get;}

        public TiendaDeRopa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Vendedores = new List<Vendedor>();
            prendasParaVender = new List<Prenda>();
        }

        public void AgregarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }
        
        /*public void generarStockInicial()
        {
            //MagicNumbers usados solo con el fin de generar stock inicial
            
            for (int i = 0; i < 1000; i++)
            {
                if (i < 500)
                {
                    if (i < 200)
                    {
                        prendasParaVender.Add(new Camisa(true,true,200));
                    }
                    else
                    {
                        prendasParaVender.Add(new Camisa(true,false,300));
                    }
                }
                else
                {
                    
                }
            }
        }*/
        
        
    }
}