
namespace HelloWorld;
class Program
{

    static void Main()
    {
        Console.WriteLine("EXERCÍCIO 1:");
        Thread.Sleep(2000);
        Console.WriteLine("Olá novato, gostaria de saber, qual o seu nome?");
        string resusuario = Console.ReadLine();
        Console.WriteLine("Seja muito bem vindo " + resusuario + ", é um prazer te conhecer.");
        Thread.Sleep(3000);


        Console.WriteLine("EXERCÍCIO 2:");
        Thread.Sleep(2000);
        Console.WriteLine("Ola, qual seria seu nome?");
        string resnome = Console.ReadLine();
        Console.WriteLine("Muito bem, qual seria o seu sobrenome?");
        string resnome2 = Console.ReadLine();
        Console.WriteLine("Entendi, então seu nome é " + resnome +
            " " + resnome2 + "?");
        Thread.Sleep(3000);
        Console.WriteLine("EXERCÍCIO 3:");
        Thread.Sleep(2000);
        double numa = 3.14;
        double numb = -3.14;

        var res = numa + numb;
        var res1 = numa - numb;
        var res2 = numa * numb;
        var res3 = numa / numb;
        Console.WriteLine("A soma do número A(3.14) com o número B(-3.14) é:");
        Thread.Sleep(4000);
        Console.WriteLine(res);
        Thread.Sleep(1500);
        Console.WriteLine("A subtração do número A(3.14) com o número B(-3.14) é:");
        Thread.Sleep(4000);
        Console.WriteLine(res1);
        Thread.Sleep(1500);
        Console.WriteLine("A multiplicação do número A(3.14) com o número B(-3.14) é:");
        Thread.Sleep(4000);
        Console.WriteLine(res2);
        Thread.Sleep(1500);
        Console.WriteLine("A divisão do número A(3.14) com o número B(-3.14) é:");
        Thread.Sleep(4000);
        Console.WriteLine(res3);
        Thread.Sleep(2000);
        Console.WriteLine("EXERCÍCIO 4");
        Thread.Sleep(1000);
        Console.Write("Digite uma ou mais palavras: ");
        string entradaUsuario = Console.ReadLine();


        int quantidadeCaracteres = ContarCaracteres(entradaUsuario);

        Thread.Sleep(1500);
        Console.WriteLine($"A quantidade de caracteres (ignorando espaços) é: {quantidadeCaracteres}");

        Console.WriteLine("EXERCÍCIO 5");
        Thread.Sleep(1000);
        Console.WriteLine("Verificação e validação de placa de carro, você tem duas placas de carro, (EXY3987), e (CHA2188).");
        Thread.Sleep(4000);
        Console.WriteLine("Agora digite qual placa você quer verificar se está válida ou não");
        string resplaca = Console.ReadLine();

        string placavalida = "CHA2188";


        if (resplaca.Contains(placavalida, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Muito bem, sua placa está válida.");
        }
        else
        {
            Console.WriteLine("Sinto muito, sua placa está inválida.");
        }
        Thread.Sleep(1500);
        Console.WriteLine("EXERCÍCIO 6:");
        DateTime agora = DateTime.Now;


        string formatoCompleto = agora.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");


        string formatoData = agora.ToString("dd/MM/yyyy");


        string formatoHora = agora.ToString("HH:mm:ss");


        string formatoDataExtenso = agora.ToString("dd 'de' MMMM 'de' yyyy");

        Console.WriteLine("Formato completo:");
        Thread.Sleep(1500);
        Console.WriteLine(formatoCompleto);
        Thread.Sleep(1500);
        Console.WriteLine("\nApenas a data (dd/MM/yyyy):");
        Thread.Sleep(1500);
        Console.WriteLine(formatoData);
        Thread.Sleep(1500);
        Console.WriteLine("\nApenas a hora (24 horas):");
        Thread.Sleep(1500);
        Console.WriteLine(formatoHora);
        Thread.Sleep(1500);
        Console.WriteLine("\nA data com o mês por extenso:");
        Thread.Sleep(1500);
        Console.WriteLine(formatoDataExtenso);
    }




    static int ContarCaracteres(string texto)
    {
        int contador = 0;


        foreach (char caractere in texto)
        {

            if (!char.IsWhiteSpace(caractere))
            {
                contador++;
            }
        }

        return contador;
    }




}

