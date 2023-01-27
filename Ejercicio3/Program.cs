using Ejercicio3;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresiones Matemáticas");
        

        ExpresionMatematica EM1 = new ExpresionMatematica()
        {
            num1 = 5,
            num2 = 15,
        };

        ExpresionMatematica EM2 = new ExpresionMatematica()
        {
            num1 = 3,
            num2 = 24,
        };

        List<ExpresionMatematica> listEM = new List<ExpresionMatematica>();

        listEM.Add(EM1);
        listEM.Add(EM2);

        foreach(ExpresionMatematica e in listEM)
        {
            Console.WriteLine($"Suma: {e.suma()}");
            Console.WriteLine($"Resta: {e.resta()}");
            Console.WriteLine($"Multiplicación: {e.multiplicacion()}");
            Console.WriteLine($"Division: {e.division()}");
            Console.WriteLine($"Máximo: {e.max()}");
            Console.WriteLine($"Mínimo: {e.min()}");
        }
    }
}