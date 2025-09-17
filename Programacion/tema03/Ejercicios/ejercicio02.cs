// ver si la suma de dos numeros es par y positivo 
using System;

public class sumaPositivaPar
{
    public static void Main(string[] args)
    {
        int numero1, numero2, suma;
        Console.Write("Introduce el primer numero: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo numero: ");
        numero2 = int.Parse(Console.ReadLine());
        suma = numero1 + numero2;
        if (suma > 0 && suma % 2 == 0)
        {
            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es " + suma + " que es un numero positivo y par.");
        }
        else
        {
            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es " + suma + " que no es un numero positivo y par.");
        }
    }
}