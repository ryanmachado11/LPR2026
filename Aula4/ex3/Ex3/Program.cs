namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao selecionador de classes!\n1 - Mago\n2 - Guerreiro\n3 - Arqueiro");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu a classe Guerreira! Suas halidades são: Ataque Pesado, Defesa Total");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a classe Mago! Suas habilidades são: Bola de Fogo, Escudo de Gelo");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a classe Arqueiro! Suas habilidades são: Flecha Precisa, Disparo Triplo");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }            
        }
    }
}
