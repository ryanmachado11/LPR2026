using System;

struct Personagem
{
    public string NomeHeroi;
    public string Habilidade;
    public int Forca;
}

struct Time
{
    public Personagem[] Integrantes;
}

class Program
{
    static Personagem[] cadastroHerois = new Personagem[5];
    static int totalCadastrados = 0;

    static Time equipeAtual;

    static void Main()
    {
        equipeAtual.Integrantes = new Personagem[3];

        menuPrincipal();
    }

    static void cadastrarHeroi()
    {
        if (totalCadastrados >= cadastroHerois.Length)
        {
            Console.WriteLine("Limite máximo de heróis atingido.");
            return;
        }

        Console.Write("\nNome do herói: ");
        cadastroHerois[totalCadastrados].NomeHeroi = Console.ReadLine();

        Console.Write("Poder/Habilidade: ");
        cadastroHerois[totalCadastrados].Habilidade = Console.ReadLine();

        Console.Write("Pontuação: ");
        cadastroHerois[totalCadastrados].Forca = Convert.ToInt32(Console.ReadLine());

        totalCadastrados++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void selecionarEquipe()
    {
        if (totalCadastrados < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis antes de montar a equipe.");
            return;
        }

        Console.WriteLine("\n===== HERÓIS DISPONÍVEIS =====");

        for (int i = 0; i < totalCadastrados; i++)
        {
            Console.WriteLine($"{i + 1} - {cadastroHerois[i].NomeHeroi} ({cadastroHerois[i].Habilidade})");
        }

        for (int i = 0; i < equipeAtual.Integrantes.Length; i++)
        {
            Console.Write($"\nEscolha o herói {i + 1}: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            while (escolha < 1 || escolha > totalCadastrados)
            {
                Console.Write("Opção inválida. Digite novamente: ");
                escolha = Convert.ToInt32(Console.ReadLine());
            }

            equipeAtual.Integrantes[i] = cadastroHerois[escolha - 1];
        }

        Console.WriteLine("Equipe formada com sucesso!");
    }

    static int calcularPontuacaoTotal()
    {
        int soma = 0;

        foreach (Personagem heroi in equipeAtual.Integrantes)
        {
            soma += heroi.Forca;
        }

        return soma;
    }

    static void exibirEquipe()
    {
        bool equipeExiste = false;

        Console.WriteLine("\n===== EQUIPE MONTADA =====");

        for (int i = 0; i < equipeAtual.Integrantes.Length; i++)
        {
            if (equipeAtual.Integrantes[i].NomeHeroi != null)
            {
                equipeExiste = true;

                Console.WriteLine(
                    $"{i + 1}. {equipeAtual.Integrantes[i].NomeHeroi} | " +
                    $"Poder: {equipeAtual.Integrantes[i].Habilidade} | " +
                    $"Pontuação: {equipeAtual.Integrantes[i].Forca}"
                );
            }
        }

        if (!equipeExiste)
        {
            Console.WriteLine("Nenhuma equipe foi selecionada.");
            return;
        }

        Console.WriteLine($"\nPontuação Total da Equipe: {calcularPontuacaoTotal()}");
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n========== MENU ==========");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;

                case 2:
                    selecionarEquipe();
                    break;

                case 3:
                    exibirEquipe();
                    break;

                case 4:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 4);
    }
}