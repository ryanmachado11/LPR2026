Console.Write("Informe as horas de treino por dia (segunda a sexta): ");
int horas = int.Parse(Console.ReadLine());
     
int meta = 1000;
int acumulador = 0;
int days = 0;

while (acumulador < meta)
{
    acumulador += horas;
    days++;
}
  
double semanas = (double)days / 5;
double meses = semanas / 4.5;

Console.WriteLine($"Total de horas: {acumulador}h");
Console.WriteLine($"Dias necessários: {days} dias");
Console.WriteLine($"Semanas necessárias: {semanas:F2} semanas");
Console.WriteLine($"Meses necessários: {meses:F2} meses");