int[] numeros = new int[10];
int qntpares = 0;
int qtdimpares = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número:");
    numeros[i] = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
    if (numeros[i] % 2 == 0)
    {
        qntpares++;
    }
    else
    {
        qtdimpares++;
    }
}
int[] numerospares = new int[qntpares];
int[] numerosimpares = new int[qtdimpares];
int indicePares = 0;
int indiceImpares = 0;
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        numerospares[indicePares] = numero;
        indicePares++;
    }
    else
    {
        numerosimpares[indiceImpares] = numero;
        indiceImpares++;
    }
}
Console.WriteLine("Números pares:");
foreach (int numero in numerospares)
{
    Console.Write(numero + " ");
}
Console.WriteLine();
Console.WriteLine("Números ímpares:");
foreach (int numero in numerosimpares)
{
    Console.Write(numero + " ");
}