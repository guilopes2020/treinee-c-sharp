// See https://aka.ms/new-console-template for more information

// calcularImc();

// static void calcularImc()
// {
//     Console.WriteLine("Hello, World!");

//     Console.WriteLine("Digite seu nome");
//     string nome = Console.ReadLine();

//     Console.WriteLine("digite sua idade");
//     int idade = int.Parse(Console.ReadLine());

//     Console.WriteLine("digite seu peso");
//     double peso = double.Parse(Console.ReadLine());

//     Console.WriteLine("digite sua altura");
//     double altura = double.Parse(Console.ReadLine());

//     double imc = peso / (altura * altura);

//     Console.WriteLine($"Olá {nome}, vc tem {idade} anos e seu imc é: {imc}");
//     Console.WriteLine("seu IMC é: " + imc);
// }

// string[] carros = new string[] {"fusca", "gol", "palio", "vectra", "kicks"};

// foreach(string carro in carros) {
//     Console.WriteLine(carro);
// }

// string message = "olá mundo!";

// string resultado = message.Substring(0, message.Length -1);

// Console.WriteLine(resultado);

// dateTimeExemplos();

// static void dateTimeExemplos()
// {
//     DateTime dataInicio = new DateTime(2023, 10, 01, 14, 25, 32);

//     Console.WriteLine($"data inicio: {dataInicio.ToString("dd/MM/yy HH:mm:ss")}");

//     DateTime hoje = DateTime.Now;

//     Console.WriteLine(hoje);
// }

// int age = Convert.ToInt32(Console.ReadLine());

// bool a = (age == 41);

// Console.WriteLine($"a idade é 41: {a}");

// if (age < 18)
// {
//     Console.WriteLine("voce é menor de idade!");
//     return;
    
// }

// if (age >= 65)
// {
//     Console.WriteLine("voce já é um idoso!");
//     return;
// }

//     Console.WriteLine("você é maior de idade");
//     Console.WriteLine("e voce tambem ja pode dirigir");

//     Console.WriteLine(RetornarEstacoesDoAno(DateTime.Now));
//     Console.WriteLine(RetornarEstacoesDoAno(new DateTime(2022, 1, 1)));
//     Console.WriteLine(RetornarEstacoesDoAno(new DateTime(2022, 5, 19)));
//     Console.WriteLine(RetornarEstacoesDoAno(new DateTime(2022, 10, 29)));

//     static string RetornarEstacoesDoAno(DateTime data) => data.Month switch
//     {
//         >= 3 and <= 6 => "Outono",
//         >= 6 and <= 9 => "Inverno",
//         >= 9 and <= 12 => "Primavera",
//         12 or (>=1 and <3) => "verão",
//         _=> "erro"
//     };

Console.WriteLine("digite o primeiro numero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

int soma = Calculadora.calcularSoma(numero1, numero2);
int subtracao = Calculadora.calcularSubtracao(numero1, numero2);
int multiplicacao = Calculadora.calcularMultiplicacao(numero1, numero2);
int divisao = Calculadora.calcularDivisao(numero1, numero2);

Console.WriteLine($"a soma de {numero1} + {numero2} é: {soma}");
Console.WriteLine($"a subtração de {numero1} - {numero2} é: {subtracao}");
Console.WriteLine($"a multiplicação de {numero1} x {numero2} é: {multiplicacao}");
Console.WriteLine($"a divisão de {numero1} / {numero2} é: {divisao}");
