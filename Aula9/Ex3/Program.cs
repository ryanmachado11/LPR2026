using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new();
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            numeros.Add(random.Next(0, 101));
        }

        numeros.Sort();

        Console.WriteLine("Números em ordem crescente:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        numeros.RemoveAll(num => num % 2 == 0);

        Console.WriteLine("\n\nNúmeros ímpares:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        List<int> repetidos = new();

        foreach (int num in numeros)
        {
            int contador = 0;

            foreach (int outro in numeros)
            {
                if (num == outro)
                {
                    contador++;
                }
            }

            if (contador > 1 && !repetidos.Contains(num))
            {
                repetidos.Add(num);
            }
        }

        Console.WriteLine("\n\nNúmeros repetidos:");

        if (repetidos.Count > 0)
        {
            foreach (int num in repetidos)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("Nenhum número repetido.");
        }
    }
}