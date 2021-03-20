using System;

namespace Problema2Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {12,345,2,6,7896};
            cuantos_pares(arr);
        }
    public static void cuantos_pares(int[] arr){
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if((arr[i] % 2) == 0)
            {
                count++;
            }
        }
        Console.WriteLine("La cantidad de numeros pares en arreglo es: " + count);
    }

    }

    
}
