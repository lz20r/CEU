// Contar del 1 al 10 con while
using System;
public class ContarDoWhile
{
  public static void Main()
  {
    int contador = 1;
    do
    {
      Console.Write(contador + " ");
      contador++;
    } while (contador <= 10);
  }
}