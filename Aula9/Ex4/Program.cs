using System;
using System.Collections.Generic;

namespace Campeonato
{
    struct Piloto
    {
        public string Nome;
        public string Equipe;
        public int Pontuacao;
    }

    class Program
    {
        static List<Piloto> listaPilotos = new List<Piloto>();
        const int TOTAL_PILOTOS = 10;

        static void Main(string[] args)
        {
            PreencherPilotos();

            Console.WriteLine();
            Console.WriteLine("========== RANKING DO CAMPEONATO ==========");
            ExibirRanking();

            double mediaGeral = CalcularPontuacaoMedia();
            Console.WriteLine();
            Console.WriteLine("Média geral de pontos: " + mediaGeral.ToString("F2"));

            int totalAcimaMedia = ContarPilotosAcimaDaMedia(mediaGeral);
            Console.WriteLine("Quantidade de pilotos acima da média: " + totalAcimaMedia);

            Console.WriteLine();
            ExibirMelhorEquipe();
        }

        static void PreencherPilotos()
        {
            for (int contador = 1; contador <= TOTAL_PILOTOS; contador++)
            {
                Console.WriteLine();
                Console.WriteLine("--- Cadastro do piloto " + contador + " ---");
                CadastrarPiloto();
            }
        }

        static void CadastrarPiloto()
        {
            Piloto novoPiloto;
            novoPiloto.Nome = "";
            novoPiloto.Equipe = "";
            novoPiloto.Pontuacao = 0;

            Console.Write("Digite o nome do piloto: ");
            novoPiloto.Nome = Console.ReadLine();

            Console.Write("Digite a equipe do piloto: ");
            novoPiloto.Equipe = Console.ReadLine();

            Console.Write("Digite a pontuação do piloto: ");
            novoPiloto.Pontuacao = Convert.ToInt32(Console.ReadLine());

            listaPilotos.Add(novoPiloto);
        }

        static void ExibirRanking()
        {
            List<Piloto> pilotosOrdenados = OrdenarPorPontuacao(listaPilotos);

            for (int i = 0; i < pilotosOrdenados.Count; i++)
            {
                Piloto atual = pilotosOrdenados[i];
                Console.WriteLine(
                    (i + 1) + "º lugar -> " + atual.Nome +
                    " | Equipe: " + atual.Equipe +
                    " | Pontos: " + atual.Pontuacao
                );
            }
        }

        static List<Piloto> OrdenarPorPontuacao(List<Piloto> origem)
        {
            List<Piloto> copia = new List<Piloto>(origem);

            for (int i = 0; i < copia.Count - 1; i++)
            {
                for (int j = 0; j < copia.Count - 1 - i; j++)
                {
                    if (copia[j].Pontuacao < copia[j + 1].Pontuacao)
                    {
                        Piloto temp = copia[j];
                        copia[j] = copia[j + 1];
                        copia[j + 1] = temp;
                    }
                }
            }

            return copia;
        }

        static double CalcularPontuacaoMedia()
        {
            if (listaPilotos.Count == 0)
                return 0;

            int somaTotal = 0;
            foreach (var piloto in listaPilotos)
            {
                somaTotal += piloto.Pontuacao;
            }

            return (double)somaTotal / listaPilotos.Count;
        }

        static int ContarPilotosAcimaDaMedia(double media)
        {
            int total = 0;
            foreach (var piloto in listaPilotos)
            {
                if (piloto.Pontuacao > media)
                {
                    total++;
                }
            }
            return total;
        }

        static void ExibirMelhorEquipe()
        {
            Dictionary<string, int> pontosPorEquipe = new Dictionary<string, int>();

            foreach (var piloto in listaPilotos)
            {
                if (!pontosPorEquipe.ContainsKey(piloto.Equipe))
                {
                    pontosPorEquipe.Add(piloto.Equipe, 0);
                }
                pontosPorEquipe[piloto.Equipe] += piloto.Pontuacao;
            }

            string equipeVencedora = "";
            int maiorSoma = -1;

            foreach (KeyValuePair<string, int> par in pontosPorEquipe)
            {
                if (par.Value > maiorSoma)
                {
                    maiorSoma = par.Value;
                    equipeVencedora = par.Key;
                }
            }

            Console.WriteLine("Equipe com maior pontuação total: " + equipeVencedora + " (" + maiorSoma + " pontos)");
        }
    }
}