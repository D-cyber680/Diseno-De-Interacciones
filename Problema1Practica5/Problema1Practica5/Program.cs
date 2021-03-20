using System;

namespace Problema1Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,1,2,1,2};
            hallar_elemento_repetido(arr);

        }

        public static bool es_valor_unico(int num, int[] arr)
        {
           int  count = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == num) 
                {
                    count += 1;
                }
            }
            return count == 1;
        }

        public static void hallar_elemento_repetido(int[] arr)
        {
            int no_repetido = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (es_valor_unico(arr[i],arr))
                {
                    no_repetido = arr[i];
                }
            }
            Console.WriteLine("El numero que no se repite es: " + no_repetido);          
        }


    }
}
