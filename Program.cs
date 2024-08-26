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

string[] carros = new string[] {"fusca", "gol", "palio", "vectra", "kicks"};

foreach(string carro in carros) {
    Console.WriteLine(carro);
}

string message = "olá mundo!";

string resultado = message.Substring(0, message.Length -1);

Console.WriteLine(resultado);

dateTimeExemplos();

static void dateTimeExemplos()
{
    DateTime dataInicio = new DateTime(2023, 10, 01, 14, 25, 32);

    Console.WriteLine($"data inicio: {dataInicio.ToString("dd/MM/yy HH:mm:ss")}");

    DateTime hoje = DateTime.Now;

    Console.WriteLine(hoje);
}
