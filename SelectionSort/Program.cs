using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[] { 5, 10, 3, 6, 2 };
            int numeroTemporario;

            for (int i = 0; i < numeros.Length -1; i++)
            {
                var numeroMinimo = i;

                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[j] < numeros[numeroMinimo])
                    {
                        numeroMinimo = j;
                    }
                }

                numeroTemporario = numeros[numeroMinimo];
                numeros[numeroMinimo] = numeros[i];
                numeros[i] = numeroTemporario;
            }
        }
    }
}
