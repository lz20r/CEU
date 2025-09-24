// 4.4 Calcular la suma de todos los Multiplos de 5 comprendidos entre 1 y 100. Calcular además
// cuántos hay y visualizar cada uno de ellos
using System;

public class SumarMultiplosCinco
{
    public static void Main()
    {
        int suma = 0;
        int contador = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 5 == 0)
            {
                suma += i;
                contador++;
                Console.WriteLine("Multiplo de 5 encontrado: " + i);
            }
        }

        Console.WriteLine("La suma de todos los Multiplos de 5 entre 1 y 100 es: " + suma);
        Console.WriteLine("La cantidad de Multiplos de 5 entre 1 y 100 es: " + contador);
    }
}