using System;
using System.Collections.Generic;
using System.Text;

namespace NoacionPolacaLib
{
    public class NotacionPolacaClass
    {
        Queue<char> salida = new Queue<char>();
        Stack<char> pila = new Stack<char>();

        public string ObtenerNotacion(string cadena)
        {
            for(int i = 0; i<cadena.Length; i++)
            {
                if (cadena[i] != '+' && cadena[i] != '-' && cadena[i] != '*' && cadena[i] != '/' && cadena[i] != '(' && cadena[i] != ')')
                    salida.Enqueue(cadena[i]);
                else if (pila.Count == 0 && (cadena[i] == '+' || cadena[i] == '-' || cadena[i] == '*' || cadena[i] == '/'))
                    pila.Push(cadena[i]);
                else if((pila.Peek() == '+' || pila.Peek() == '-')&&(cadena[i] == '+' || cadena[i] == '-'))
                {
                    salida.Enqueue(pila.Peek());
                    pila.Push(cadena[i]);
                }
                else if ((pila.Peek() == '*' || pila.Peek() == '/') && (cadena[i] == '*' || cadena[i] == '/'))
                {
                    salida.Enqueue(pila.Peek());
                    pila.Push(cadena[i]);
                }
                else
                {
                    pila.Push(cadena[i]);
                }
            }

            StringBuilder cadenaFinal = new StringBuilder();
            foreach (var item in salida)
                cadenaFinal.Append(item);
            return cadenaFinal.ToString();
        }
    }
}
