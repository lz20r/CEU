// sumar cuadrados del 1 al 10 con for

using System;

public class SumarCuadradosFor
{
    public static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 10; i++)
        {
            suma += i * i;
        }

        Console.WriteLine("La suma de los cuadrados del 1 al 10 es: " + suma);
    }
}