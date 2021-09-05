using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            /*
            Estos metodos deberian ser llamados de otra clase, una que sea responsable de manipular los libros, en este caso, almacenarlos
            */
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");


        }
    }
}
