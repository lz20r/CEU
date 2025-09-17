using System;

public class comparacionNumeros
{
    public static void Main(string[] args)
    {
        // comprobar cual de dos números es mayor o menor o si son iguales
        int numero1, numero2;
        Console.Write("Introduce el primer numero: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo numero: ");
        numero2 = int.Parse(Console.ReadLine());
        if (numero1 > numero2)
        {
            Console.WriteLine("El numero " + numero1 + " es mayor que " + numero2);
        }
        else if (numero1 < numero2)
        {
            Console.WriteLine("El numero " + numero1 + " es menor que " + numero2);
        }
        else
        {
            Console.WriteLine("Los numeros son iguales.");
        }
    }
}