using System;
using System.Collections.Generic;
class Program
{
 static void Main()
 {
    List<int> notas = new();
    int nota;
    int media;
    int contadormedia = 0;
    int maiorNota = 0;
    int menorNota = 0;
    
    for(int i=0; i<5; i++)
    {
        Console.WriteLine("Insira a primeira nota da lista");
        nota = int.Parse(Console.WriteLine());
        notas.Add(nota);

        if(nota>maiorNota){ maiorNota = nota; }
        if(nota<menorNota){ menorNota = nota; }
    }
 }
}