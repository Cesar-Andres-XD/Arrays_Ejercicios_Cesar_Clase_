using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Arrays_Ejercicios_Cesar_Clase_.Clases
{
    internal class Ejercicios_en_clases_
    {

        /*
        public void Ejercicio_1()
        {
            int[,] aaa =
            {
                { 1, 2, 3}, 
                { 4, 5, 6}, 
                { 7, 8, 9},
            };
            Console.WriteLine("La matriz es: ");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.WriteLine(aaa[fila,columna]);
                }
            }
        }
        */



        /*
        public void Ejercicio_2()
        {
            string[,] colores =
            {
               { "Rojo", "Verde" },
               { "Azul", "Amarillo" },
            };
            for (int l = 0; l < 2; l++)
            {
                for (int columnas = 0; columnas < 2; columnas++)
                {
                    Console.WriteLine(colores[l,columnas]);
                }
            }
        }
        */



        /*
        public void Ejercicio_3()
        {
            double resultado = 0;
            double[,] ssf =
            {
                { 1.1, 2.2, 3.3 },
                { 4.1, 5.2, 6.3 },
                { 7.1, 8.2, 9.3 },
                { 10.1, 11.2, 12.3 },
            };
            for (int a = 0; a < 4; a++)
            {
                for (int w = 0; w < 3; w++)
                {
                    resultado += ssf[a, w];                                  
                }
            }
            Console.WriteLine(resultado);
        */



        /*
        public void Asesoria() 
        {
            Console.WriteLine("Ingresa longitud");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[longitud];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingresa un numero");
                array[i] = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine(string.Join(" ", array));
        */



        /*
        public void Ejercicio_4()
        {
            string[,] alfabeticos =
            {
                { "A B C", "D E F", "G H I ", "J K L M" },
                { "N Ñ O ", "P Q R ", "S T U ", "V W X Y Z"},                
            };
            // A, B, C, D, E, F, G, H, I, J, K, L, M, N, Ñ, O, P, Q, R, S, T, U, V, W, X, Y, Z.

            for (int ri = 0; ri < 2; ri++)
            {
                for (int sa = 0; sa < 4; sa++)
                {
                    Console.WriteLine(alfabeticos[ri,sa]);
                }
            }
        }
        */


        /*
        public void Ejercicio_5()
        {
            bool[,] boleano = 
            {
                { false , true}, 
                { true , false}, 
                { false , false},
            };
            for (int q = 0; q < 3; q++)
            {
                for (int r  = 0; r < 2; r++)
                {
                    Console.WriteLine(boleano[q,r]);
                }
            }
        }
        */
        
    }

}
