using System;
using NotPolaca;

namespace NotacionPolaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "5+2-3*6+1";
            NotPolaca.NotPolaca notacion = new NotPolaca.NotPolaca();
            string texto = notacion.ObtenerNotacion(cadena);
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
