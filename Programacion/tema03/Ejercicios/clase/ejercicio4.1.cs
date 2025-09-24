// 4.1 Calcular el factorial de un numero introducido por teclado. Antes de realizar el cálculo deberá omprobarse que el numero es positivo y en caso contrario se imprimirá un mensaje de error

using System;
public class FactorialNumero
{
    public static void Main()
    {
        Console.Write("Introduce un numero positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Error: El numero debe ser positivo.");
        }
        else
        {
            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }
    }
}