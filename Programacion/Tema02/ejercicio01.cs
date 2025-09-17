using System;

public class Tiempo
{
    public static void Main(string[] args)
    {
        int dias = 12;
        int horas = 2;
        int meses = 3;
        
        int diasPorMes = 30; 
        int horasPorDia = 24;
        int segundoPorHora = 3600;
        
        int segundoMeses = meses * diasPorMes * horasPorDia * segundoPorHora;
        int segundoDias = dias * horasPorDia * segundoPorHora;
        int segundoHoras = horas * segundoPorHora;
        
        Console.WriteLine("Segundos en " + meses + " meses es " + segundoMeses);
        Console.WriteLine("Segundos en " + dias + " dias es " + segundoDias);
        Console.WriteLine("Segundos en " + horas + " horas es " + segundoHoras);
    }
}