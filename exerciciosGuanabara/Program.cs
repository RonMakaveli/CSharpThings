using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha um programa para executar:");
        Console.WriteLine("1 - Conversão de Reais para Dólares");
        Console.WriteLine("2 - Conversão de Fahrenheit para Celsius");
        Console.WriteLine("3 - Cálculo de Imposto em Dólares");
        Console.WriteLine("4 - Empréstimo com Juros");
        Console.WriteLine("5 - Calcular Idade");
        Console.WriteLine("Digite o número do programa:");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                ConverterReaisParaDolares();
                break;
            case 2:
                ConverterFahrenheitParaCelsius();
                break;
            case 3:
                CalcularImpostoEmDolares();
                break;
            case 4:
                CalcularEmprestimoComJuros();
                break;
            case 5:
                CalcularEmprestimoComJuros();
                break;
            default:
                Console.WriteLine("Escolha inválida. Programa encerrado.");
                break;
        }

        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }

    static void ConverterReaisParaDolares()
    {
        float reais, dolares;

        Console.WriteLine("Quantos reais você tem?");
        reais = Convert.ToSingle(Console.ReadLine());

        dolares = reais / 4.79f;

        Console.WriteLine("O valor em dólares é: " + dolares.ToString("F2"));
    }

    static void ConverterFahrenheitParaCelsius()
    {
        float f, c;

        Console.WriteLine("Qual é a temperatura em Fahrenheit?");
        f = Convert.ToSingle(Console.ReadLine());

        c = (f - 32) / 1.8f;
        Console.WriteLine("A temperatura em Celsius é: " + c.ToString("F2") + "°C");
    }

    static void CalcularImpostoEmDolares()
    {
        float preco, imposto;

        Console.WriteLine("Qual o preço do produto em dólares?");
        preco = float.Parse(Console.ReadLine());

        imposto = (preco * 60) / 100;
        Console.WriteLine("O imposto será de US$: " + imposto.ToString("F2"));
    }

    static void CalcularEmprestimoComJuros()
    {
        float emprestimo, total, valorParcela;
        int parcelas;
        string porcentagem;

        Console.WriteLine("Quanto você quer de empréstimo em reais?");
        emprestimo = float.Parse(Console.ReadLine());

        Console.WriteLine("Quantas parcelas você quer?");
        parcelas = int.Parse(Console.ReadLine());

        if (emprestimo > 1500)
        {
            total = emprestimo * 1.4f;
            porcentagem = "40%";
        }
        else if (emprestimo > 1000)
        {
            total = emprestimo * 1.3f;
            porcentagem = "30%";
        }
        else
        {
            total = emprestimo * 1.2f;
            porcentagem = "20%";
        }

        valorParcela = total / parcelas;

        Console.WriteLine("O empréstimo será de: " + emprestimo.ToString("F2") + " com juros sobre o total ao mês");
        Console.WriteLine("O valor total será de: " + total.ToString("F2") + " com " + porcentagem + " sobre o total ao mês");

        Console.WriteLine("O valor de cada parcela será: " + valorParcela.ToString("F2"));
    }
}
