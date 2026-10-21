namespace Aula10.Ex1
{
    class Funcionario
    {
        string nome;
        double salario_bruto;

        public Funcionario(string nome, double salario_bruto)
        {
            this.nome = nome;
            this.salario_bruto = salario_bruto;
        }

        public double calcSalarioLiquido()
        {
            if (salario_bruto <= 2000)
            {
                return salario_bruto * 0.9;
            }
            else if (salario_bruto <= 3000)
            {
                return salario_bruto * 0.85;
            }
            else
            {
                return salario_bruto * 0.8;
            }
        }

        public string dados_funcionario()
        {
            return $"Nome: {nome}, Salário Bruto: {salario_bruto}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o salário bruto do funcionário:");
            double salario_bruto = double.Parse(Console.ReadLine());
            
            Funcionario funcionario1 = new Funcionario(nome, salario_bruto);

            Console.WriteLine("Digite 1 para ver os dados do funcionário ou 2 para calcular o salário líquido:");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine(funcionario1.dados_funcionario());
                    break;
                case 2:
                    Console.WriteLine("O salário líquido do funcionário é: {0}", funcionario1.calcSalarioLiquido());
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        }
    }

}