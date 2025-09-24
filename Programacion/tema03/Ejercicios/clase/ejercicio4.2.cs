// 4.2 Calcular la suma de los 100 primeros numeros naturales
using System;
public class SumarCienNaturales
{
    public static void Main()
    {
        int suma = 0;
        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los 100 primeros numeros naturales es: " + suma);
    }
}