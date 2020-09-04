using System;
using System.Data;
namespace SRP
{
    public class Libreria
    {
        public Dictonary<string,Libro> estantes{get;set;}

        public Libreria()
        {
            estantes=new Dictonary<string, Libro>();
        }

        public void AlmacenarLibro(String sector, String estante,Libro libro)
        {
            string ubicacion=estante+","+sector;
            estantes.Add(ubicacion,libro);
        }

    }
}