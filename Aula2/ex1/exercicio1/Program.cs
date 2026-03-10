using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite o valor do raio do seu circulo: ");
        if (double.TryParse(Console.ReadLine(), out double raio))

        {
            if (raio < 0)
            {
                Console.WriteLine("o raio do seu circulo é negativo, isso está incorreto");
            }
            else if (raio > 0)
            {
                double area = Math.PI * Math.Pow(raio, 2);
                Console.WriteLine($"a area do circulo é: {area}");
            }
            else
            {
                Console.WriteLine("este caracter é invalido");
            }

        }
    }
}
