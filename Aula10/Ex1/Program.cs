namespace Aula10.Ex1
{
    class Retangulo
    {
        double altura;
        double largura;

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }
       
        public double calcArea()
        {
            return altura * largura;
        }

        public double calcPerimetro()
        {
            return 2 * (altura + largura);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a largura do retângulo:");
            double largura = double.Parse(Console.ReadLine());

            Retangulo retangulo1 = new Retangulo(altura, largura);
            Console.WriteLine("A área do retângulo é: {0}, e seu perímetro é: {1}", retangulo1.calcArea(), retangulo1.calcPerimetro());
        }
    }
}