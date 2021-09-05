using System;

namespace SRP
{
    public class Libro
    {
public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        /*
        Los atributos SectorBiblioteca y EstanteBiblioteca podrian ser properties de una clase que contenga los libros ya que si a estos les damos
        la responsabilidad de almacenarse a si mismos no estariamos cumpliendo con la SRP
        */
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /* 
        Los libros no deberian ser los responsables de almacenarse, lo mejor seria tener una clase llamada Biblioteca, la cual sera
        responsable de guardar los libros
        */
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
