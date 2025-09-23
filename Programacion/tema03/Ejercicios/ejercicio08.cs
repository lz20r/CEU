// Imprime por pantalla todos los números del 1 al 100 que son pares con for

using System;
public class NumerosParesFor
{
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
} 