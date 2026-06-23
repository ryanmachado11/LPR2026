using System;

struct Chamado
{
    public int Codigo;
    public string Funcionario;
    public string Departamento;
    public int NivelPrioridade;
    public string Situacao;
    public string Detalhes;
}

class Program
{
    static Chamado[] registros = new Chamado[10];
    static int totalRegistros = 0;

    static void Main()
    {
        int escolha;

        do
        {
            Console.WriteLine("\n===== CENTRAL DE CHAMADOS =====");
            Console.WriteLine("1 - Registrar chamado");
            Console.WriteLine("2 - Consultar chamados");
            Console.WriteLine("3 - Alterar status");
            Console.WriteLine("4 - Ver estatísticas");
            Console.WriteLine("5 - Encerrar");
            Console.Write("Opção desejada: ");

            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    cadastrarChamado();
                    break;

                case 2:
                    listarChamados();
                    break;

                case 3:
                    atualizarStatus();
                    break;

                case 4:
                    estatisticas();
                    break;

                case 5:
                    Console.WriteLine("Sistema finalizado.");
                    break;

                default:
                    Console.WriteLine("Opção inexistente.");
                    break;
            }

        } while (escolha != 5);
    }

    static void cadastrarChamado()
    {
        if (totalRegistros >= registros.Length)
        {
            Console.WriteLine("Capacidade máxima atingida.");
            return;
        }

        Console.WriteLine("\n=== NOVO CHAMADO ===");

        Console.Write("Código: ");
        registros[totalRegistros].Codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nome do solicitante: ");
        registros[totalRegistros].Funcionario = Console.ReadLine();

        Console.Write("Departamento: ");
        registros[totalRegistros].Departamento = Console.ReadLine();

        Console.Write("Prioridade (1, 2 ou 3): ");
        registros[totalRegistros].NivelPrioridade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Descrição do problema: ");
        registros[totalRegistros].Detalhes = Console.ReadLine();

        registros[totalRegistros].Situacao = "Aberto";

        totalRegistros++;

        Console.WriteLine("Chamado registrado com sucesso.");
    }

    static void listarChamados()
    {
        if (totalRegistros == 0)
        {
            Console.WriteLine("Nenhum chamado encontrado.");
            return;
        }

        Console.WriteLine("\n===== RELATÓRIO DE CHAMADOS =====");

        for (int i = 0; i < totalRegistros; i++)
        {
            Console.WriteLine($"\nCódigo: {registros[i].Codigo}");
            Console.WriteLine($"Solicitante: {registros[i].Funcionario}");
            Console.WriteLine($"Setor: {registros[i].Departamento}");
            Console.WriteLine($"Prioridade: {classificarPrioridade(registros[i].NivelPrioridade)}");
            Console.WriteLine($"Status: {registros[i].Situacao}");
            Console.WriteLine($"Descrição: {registros[i].Detalhes}");
        }
    }

    static void atualizarStatus()
    {
        Console.Write("\nInforme o código do chamado: ");
        int codigoBusca = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < totalRegistros; i++)
        {
            if (registros[i].Codigo == codigoBusca)
            {
                Console.WriteLine("\n1 - Em andamento");
                Console.WriteLine("2 - Resolvido");
                Console.WriteLine("3 - Cancelado");
                Console.Write("Escolha o novo status: ");

                int novoStatus = Convert.ToInt32(Console.ReadLine());

                switch (novoStatus)
                {
                    case 1:
                        registros[i].Situacao = "Em andamento";
                        break;

                    case 2:
                        registros[i].Situacao = "Resolvido";
                        break;

                    case 3:
                        registros[i].Situacao = "Cancelado";
                        break;

                    default:
                        Console.WriteLine("Status inválido.");
                        return;
                }

                Console.WriteLine("Atualização concluída.");
                return;
            }
        }

        Console.WriteLine("Chamado não localizado.");
    }

    static string classificarPrioridade(int prioridade)
    {
        if (prioridade == 1)
            return "Baixa";

        if (prioridade == 2)
            return "Média";

        if (prioridade == 3)
            return "Alta";

        return "Inválida";
    }

    static void estatisticas()
    {
        int qtdAbertos = 0;
        int qtdAndamento = 0;
        int qtdResolvidos = 0;
        int qtdCancelados = 0;

        for (int i = 0; i < totalRegistros; i++)
        {
            if (registros[i].Situacao == "Aberto")
                qtdAbertos++;

            else if (registros[i].Situacao == "Em andamento")
                qtdAndamento++;

            else if (registros[i].Situacao == "Resolvido")
                qtdResolvidos++;

            else if (registros[i].Situacao == "Cancelado")
                qtdCancelados++;
        }

        Console.WriteLine("\n===== ESTATÍSTICAS =====");
        Console.WriteLine($"Chamados abertos: {qtdAbertos}");
        Console.WriteLine($"Chamados em andamento: {qtdAndamento}");
        Console.WriteLine($"Chamados resolvidos: {qtdResolvidos}");
        Console.WriteLine($"Chamados cancelados: {qtdCancelados}");
    }
}
