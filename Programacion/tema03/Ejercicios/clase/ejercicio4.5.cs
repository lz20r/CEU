// 4.5 Escribe un programa que calcule el mínimo y el máximo de una lista de números enteros
// positivos introducidos por el usuario. La lista finalizará cuando se introduzca un número
// negativo.

using System;
public class MinimoMaximoLista 
{
    public static void Main()
    {
        int numero;
        int minimo = int.MaxValue;
        int maximo = int.MinValue;

        Console.WriteLine("Introduce numeros enteros positivos (introduce un numero negativo para finalizar):");

        while (true)
        {
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            if (numero < minimo)
            {
                minimo = numero;
            }

            if (numero > maximo)
            {
                maximo = numero;
            }
        }

        if (minimo == int.MaxValue && maximo == int.MinValue)
        {
            Console.WriteLine("No se introdujeron numeros positivos.");
        }
        else
        {
            Console.WriteLine("El numero minimo es: " + minimo);
            Console.WriteLine("El numero maximo es: " + maximo);
        }
    }
}