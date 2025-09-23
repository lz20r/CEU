//  incrementar una variable el doble de su numero hasta que alcance o supere 500 con while

using System;
public class IncrementarDobleWhile
{
    public static void Main()
    {
        int numero = 1;

        while (numero < 500)
        {
            Console.Write(numero + " ");
            numero *= 2;
        }
    }
}