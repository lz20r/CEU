// Escribe un programa que visualice por pantalla la tabla de multiplicar de los 10 primeros
// números naturales

using System;
public class TablaMultiplicar
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Tabla de multiplicar del " + i + ":");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }
            Console.WriteLine(); // Línea en blanco entre tablas
        }
    }
}