using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<float> notas = new();
        float nota;
        float media;
        float contadormedia = 0;
        float maiorNota = 0;
        float menorNota = 100;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Insira a {i+1}ª nota:");
            nota = float.Parse(Console.ReadLine()!);
            notas.Add(nota);

            if (nota > maiorNota) { maiorNota = nota; }

            if (nota < menorNota) { menorNota = nota; }

            contadormedia += nota;
        }
        
        Console.WriteLine("Todas as notas sao:");

        foreach(float n in notas)
        {
           Console.WriteLine(n);
        }

        media = contadormedia / notas.Count;

        Console.WriteLine($"A maior nota e: {maiorNota}");
        Console.WriteLine($"A menor nota e: {menorNota}");
        Console.WriteLine($"A media das notas e: {media}");
    }
}