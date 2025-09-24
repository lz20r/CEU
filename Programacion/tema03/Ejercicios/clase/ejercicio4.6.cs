// 4.6 Escribe un programa que lea un mes en número (1 para enero, 2 para febrero, etc.) y un año e
// indique el número de días de ese mes. Recuerda, el año es bisiesto si es divisible por cuatro,
// excepto cuando es divisible por 100, a no ser que sea divisible entre 400


using System;

public class DiasDelMes
{
    public static void Main()
    {
        Console.Write("Introduce un mes (1-12): ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Introduce un año: ");
        int anio = int.Parse(Console.ReadLine());

        int dias;

        switch (mes)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                dias = 31;
                break;
            case 4: case 6: case 9: case 11:
                dias = 30;
                break;
            case 2:
                if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                {
                    dias = 29; // Año bisiesto
                }
                else
                {
                    dias = 28; // Año no bisiesto
                }
                break;
            default:
                Console.WriteLine("Mes no válido. Debe estar entre 1 y 12.");
                return;
        }

        Console.WriteLine("El mes " + mes + " del año " + anio + " tiene " + dias + " días.");
    }
}