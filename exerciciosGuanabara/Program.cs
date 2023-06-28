using System;
using System.Globalization;

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
        Console.WriteLine("6 - Par ou Impar");
        Console.WriteLine("7 - Calcular IMC");
        Console.WriteLine("8 - Calcular Media");
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
                CalcularIdade();
                break;
            case 6:
                ParOuImpar();
                break;
            case 7:
                CalculoIMC();
                break;
            case 8:
                CalculoMedia();
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
    static void CalcularIdade()
    {
        int ano, nasc, idade;
        string maiorIdade;

        Console.WriteLine("Em que ano estamos");
        ano = int.Parse(Console.ReadLine());

        Console.WriteLine("Em que ano você nasceu ?");
        nasc = int.Parse(Console.ReadLine());

        idade = ano - nasc;

        if(idade >= 21)
        {
            maiorIdade = "você será maior de idade!";
        }
        else
        {
            maiorIdade = "você ainda não é maior de idade!";
        }

        Console.WriteLine("Em " + ano + " você terá " + idade + " anos, e " + maiorIdade);
    }
    static void ParOuImpar()
    {
        int n;
        Console.WriteLine("Digite qualquer numero");
        n = int.Parse(Console.ReadLine());
        if(n % 2 == 0)
        {
            Console.WriteLine("o numero " + n + " é par");
        }
        else
        {
            Console.WriteLine("O numero " + n + " é impar");
        }
    }
    static void CalculoIMC()
    {
        float massa, altura, imc;

        Console.WriteLine("Massa (KG):");
        massa= float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Altura (M):");
        altura= float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        imc = massa / (altura * altura);
   
        Console.WriteLine("IMC: " + imc.ToString("0.00"));
        if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Parabens! você está no seu peso ideal.");
        }
        else
        {
            Console.WriteLine("Você não está na faixa de peso ideal.");
        }
    }
    static void CalculoMedia()
    {
        float nota1, nota2, nota3, nota4, media;

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        nota3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        nota4 = float.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3 + nota4) / 4;

        if(media >= 7)
        {
            Console.WriteLine("A media do aluno foi " + media.ToString("F2"));
            Console.WriteLine("O aluno está aprovado.");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("A media do aluno foi " + media.ToString("F2"));
            Console.WriteLine("O aluno está de recuperação.");
        }
        else
        {
            Console.WriteLine("A media do aluno foi " + media.ToString("F2"));
            Console.WriteLine("O aluno está reprovado.");
        }
    }
}

