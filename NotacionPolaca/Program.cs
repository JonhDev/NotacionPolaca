using System;
using NotacionPolaca.Lib;

namespace NotacionPolaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "7*8-4/6+9*5+7/2-4*6/7";
            string cadena2 = "4*(6-9+7*(6+2-(9-7+3)*6-4)+7*3)-2";
            NotPolaca notacion = new NotPolaca();
            string texto = notacion.ObtenerNotacion(cadena);
            Console.WriteLine(notacion.ObtenerNotacion(cadena2));
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
