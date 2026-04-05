using System;

class Program
{
    static void Main()
    {
        string n1 = "", p1 = ""; double pt1 = 0;
        string n2 = "", p2 = ""; double pt2 = 0;
        string n3 = "", p3 = ""; double pt3 = 0;
        string n4 = "", p4 = ""; double pt4 = 0;
        string n5 = "", p5 = ""; double pt5 = 0;

        string en1 = "", ep1 = ""; double ept1 = 0;
        string en2 = "", ep2 = ""; double ept2 = 0;
        string en3 = "", ep3 = ""; double ept3 = 0;

        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n--- MENU MARVEL ---");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Escolher Equipe");
            Console.WriteLine("3 - Ver Equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            int.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 1)
            {
                cadastrar(ref n1, ref p1, ref pt1, 1);
                cadastrar(ref n2, ref p2, ref pt2, 2);
                cadastrar(ref n3, ref p3, ref pt3, 3);
                cadastrar(ref n4, ref p4, ref pt4, 4);
                cadastrar(ref n5, ref p5, ref pt5, 5);
            }
            else if (opcao == 2)
            {
                escolher(n1, p1, pt1, n2, p2, pt2, n3, p3, pt3, n4, p4, pt4, n5, p5, pt5,
                        ref en1, ref ep1, ref ept1, ref en2, ref ep2, ref ept2, ref en3, ref ep3, ref ept3);
            }
            else if (opcao == 3)
            {
                double total = somar(ept1, ept2, ept3);
                mostrar(en1, ep1, en2, ep2, en3, ep3, total);
            }
        }
    }

    static void cadastrar(ref string nome, ref string poder, ref double pontos, int num)
    {
        Console.WriteLine($"\nCADASTRO DO HEROI {num}");
        Console.Write("Nome: ");
        nome = Console.ReadLine() ?? "";
        Console.Write($"Qual o poder de {nome}? ");
        poder = Console.ReadLine() ?? "";
        Console.Write($"Pontos de {nome}: ");
        double.TryParse(Console.ReadLine(), out pontos);
    }

    static void escolher(string n1, string p1, double pt1, string n2, string p2, double pt2, 
                         string n3, string p3, double pt3, string n4, string p4, double pt4, 
                         string n5, string p5, double pt5,
                         ref string e1n, ref string e1p, ref double e1pt,
                         ref string e2n, ref string e2p, ref double e2pt,
                         ref string e3n, ref string e3p, ref double e3pt)
    {
        Console.WriteLine("\nOPÇÕES DISPONÍVEIS:");
        Console.WriteLine($"1-{n1} | 2-{n2} | 3-{n3} | 4-{n4} | 5-{n5}");

        Console.Write("Escolha o numero do heroi 1: ");
        int esc1 = int.Parse(Console.ReadLine() ?? "1");
        if (esc1 == 1) { e1n = n1; e1p = p1; e1pt = pt1; }
        if (esc1 == 2) { e1n = n2; e1p = p2; e1pt = pt2; }
        if (esc1 == 3) { e1n = n3; e1p = p3; e1pt = pt3; }
        if (esc1 == 4) { e1n = n4; e1p = p4; e1pt = pt4; }
        if (esc1 == 5) { e1n = n5; e1p = p5; e1pt = pt5; }

        Console.Write("Escolha o numero do heroi 2: ");
        int esc2 = int.Parse(Console.ReadLine() ?? "1");
        if (esc2 == 1) { e2n = n1; e2p = p1; e2pt = pt1; }
        if (esc2 == 2) { e2n = n2; e2p = p2; e2pt = pt2; }
        if (esc2 == 3) { e2n = n3; e2p = p3; e2pt = pt3; }
        if (esc2 == 4) { e2n = n4; e2p = p4; e2pt = pt4; }
        if (esc2 == 5) { e2n = n5; e2p = p5; e2pt = pt5; }

        Console.Write("Escolha o numero do heroi 3: ");
        int esc3 = int.Parse(Console.ReadLine() ?? "1");
        if (esc3 == 1) { e3n = n1; e3p = p1; e3pt = pt1; }
        if (esc3 == 2) { e3n = n2; e3p = p2; e3pt = pt2; }
        if (esc3 == 3) { e3n = n3; e3p = p3; e3pt = pt3; }
        if (esc3 == 4) { e3n = n4; e3p = p4; e3pt = pt4; }
        if (esc3 == 5) { e3n = n5; e3p = p5; e3pt = pt5; }
    }

    static double somar(double ept1, double ept2, double ept3)
    {
        return ept1 + ept2 + ept3;
    }

    static void mostrar(string n1, string p1, string n2, string p2, string n3, string p3, double total)
    {
        Console.WriteLine("\n--- EQUIPE SELECIONADA ---");
        Console.WriteLine($"Heroi 1: {n1} - Poder: {p1}");
        Console.WriteLine($"Heroi 2: {n2} - Poder: {p2}");
        Console.WriteLine($"Heroi 3: {n3} - Poder: {p3}");
        Console.WriteLine($"PONTUAÇÃO TOTAL: {total}");
        Console.WriteLine("--------------------------");
    }
}