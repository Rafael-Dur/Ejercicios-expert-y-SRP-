using System;

namespace SRP
{
    public class Libro
    {
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        /*La responsabilidad de almacenar los libros no recae en el libro, 
        ya que este no tiene la necesidad de conocer su posición
        Por lo tanto, debe ir en una nueva clase (libreria)*/
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
    }
}
