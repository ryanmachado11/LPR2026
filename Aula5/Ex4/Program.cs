Console.WriteLine("Digite um número inteiro:");
int numero = int.Parse(Console.ReadLine());
int quadrado = numero * numero;
int soma;

 while (quadrado > 0)
{
    int digito = quadrado % 10;
    soma += digito;
    quadrado /= 10;
}
Console.WriteLine($"A soma dos dígitos do quadrado é: {soma}.");

