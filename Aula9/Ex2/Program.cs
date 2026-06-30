using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> lista = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu: \n 1 - Adicionar nome na lista \n 2 - Ordenar e exibir por tamanhos \n 3 - Encerrar");
            Console.Write("Escolha uma opção: ");
            
            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                switch (opcao)
                {
                    case 1: Adicionar(); break;
                    case 2: Ordenar(); break;
                    case 3: return;
                    default: Console.WriteLine("Opção inválida."); break;
                }
            }
        }
    }

    static void Adicionar()
    {
        string add = "";
        do
        {
            Console.WriteLine("Digite o nome a ser adicionado (ou '-1' para voltar ao menu):");
            add = Console.ReadLine()!;
            
            if (add != "-1" && !string.IsNullOrWhiteSpace(add))
            {
                lista.Add(add);
                Console.WriteLine($"'{add}' adicionado!");
            }
        } while (add != "-1");
    }

    static void Ordenar()
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("A lista está vazia!");
            return;
        }

        List<string> listaTemporaria = new List<string>(lista);

        Console.WriteLine("\n--- Exibindo por tamanho (1 por linha/tamanho) ---");

        while (listaTemporaria.Count > 0)
        {
            List<string> linhaAtual = new List<string>();
            
            var tamanhos = listaTemporaria.Select(n => n.Length).Distinct().OrderBy(t => t).ToList();

            foreach (int tamanho in tamanhos)
            {
                string palavra = listaTemporaria.First(n => n.Length == tamanho);
                linhaAtual.Add(palavra);
            }

            Console.WriteLine(string.Join(", ", linhaAtual));

            foreach (string palavra in linhaAtual)
            {
                listaTemporaria.Remove(palavra);
            }
        }
    }
}