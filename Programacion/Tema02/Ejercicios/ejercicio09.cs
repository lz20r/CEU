using System;

public class ConconversionNumeros
{
    public static void Main(string[] args)
    {
       double n1 = -0.9;
       double n2 = -0.1;
       double n3 = 0.1;
       double n4 = 0.9;
       
       double i1 = (int)n1;
       double i2 = (int)n2;
       double i3 = (int)n3;
       double i4 = (int)n4;
       
       Console.WriteLine(n1 + " convertido en entero es " + i1);
       Console.WriteLine(n2 + " convertido en entero es " + i2);
       Console.WriteLine(n3 + " convertido en entero es " + i3);
       Console.WriteLine(n4 + " convertido en entero es " + i4);
    }
}

