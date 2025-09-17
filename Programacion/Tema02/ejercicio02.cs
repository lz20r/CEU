using System;

public class EcuacionCuadratica
{
    public static void Main(string[] args)
    {
        short a = 12;
        short b = 25;
        short c = 10;
        float x1 = 42.32F;
        
        double solucionSuma = ((-1*b)+(Math.Sqrt(Math.Pow(b,2)-(4*a*c))))/2*a;
        double solucionResta = ((-1*b)-(Math.Sqrt(Math.Pow(b,2)-(4*a*c))))/2*a;
        
        Console.WriteLine("x= " + solucionSuma);
        Console.WriteLine("x= " + solucionResta);
    }
}