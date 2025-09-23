// 4.3 Sumar los números pares menores que N por un lado y los impares menores que N por otro lado. N es un valor introducido por el usuario

using System;

public class SumarParesImpares
{
    public static void Main()
    {
        Console.Write("Introduce un numero entero positivo N: ");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Error: El numero debe ser positivo.");
            return;
        }

        int sumaPares = 0;
        int sumaImpares = 0;

        for (int i = 1; i < N; i++)
        {
            if (i % 2 == 0)
            {
                sumaPares += i;
            }
            else
            {
                sumaImpares += i;
            }
        }

        Console.WriteLine("La suma de los numeros pares menores que " + N + " es: " + sumaPares);
        Console.WriteLine("La suma de los numeros impares menores que " + N + " es: " + sumaImpares);
    }
}