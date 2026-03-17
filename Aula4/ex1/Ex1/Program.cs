namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Insira um número inteiro:   ");
            int.TryParse(Console.ReadLine(), out num);
            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
