using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscando_anagramas
{
    class Program
    {
        /* Buscando anagramas:        
        Se provee una cadena de caracteres de largo N y una subcadena de largo M.Se desea saber cuántas veces aparece la 
        subcadena o un anagrama de la misma dentro de la cadena principal.
        Por ejemplo, si se tiene la cadena A y la subcadena B
        A = “hola, que buena ola Laomir” 
        B = “OAL”  
        El resultado deberá ser 3, dado lo siguiente A = “hola, que buena ola Laomir” 
        Escribir una función: Int solution(string A, string B)
        que devuelva la cantidad de veces que aparece B en A, o un anagrama de B en A.
        Asumir: 
        No hay distinción entre mayúsculas y  minúsculas N > M.
        */
        static void Main(string[] args)
        {
            int solucion = Solution("hola, que buena ola Laomir", "OAL");

            int Solution(string A, string B)
            {
                A = A.ToLower();
                B = B.ToLower();
                int contador = 0;
                int acumulador = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < B.Length; j++)
                    {
                        if (A[i] == B[j])
                        {
                            contador++;
                            if ((contador == B.Length))
                            {
                                contador = 0;
                                acumulador++;
                            }
                            break;
                        }
                    }
                }
                return acumulador;
            }
            Console.WriteLine("La cantidad de veces que aparece B en A es: {0}. ", solucion);
            Console.ReadKey();
        } 
    }
}
