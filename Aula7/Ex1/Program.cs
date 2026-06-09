int[] vetor = new int[5];
int maiorint = int.MinValue;
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Digite um número:");
    vetor[i] = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;
    if (vetor[i] > maiorint)
    {
        maiorint = vetor[i];
    }
}
Console.WriteLine($"O maior número digitado foi: {maiorint} e na posicao {Array.IndexOf(vetor, maiorint)}");