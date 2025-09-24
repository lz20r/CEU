// intrtoduce numeros hasta introducir un 0. Enseñar la sumade numeros por pantalla

using System;
public class SumaNumeros
{
    public static void Main()
    {
        int numero;
        int suma = 0;

        do
        {
            Console.Write("Introduce numero (introduce 0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
            suma += numero;
        } while (numero != 0);

        Console.WriteLine("La suma de los numeros introducidos es: " + suma);
    }
}