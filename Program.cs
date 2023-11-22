// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine ("Digite seu sobrenome: "); 
string? sobrenome = Console.ReadLine();

Console.WriteLine ("Digite a sua data de nascimento no formato dd/mm/yy: "); 
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

Console.WriteLine("Digite seu CPF sem ponto ou caracter: ");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso); 

Console.WriteLine ("Digite sua altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa (nome, sobrenome, dataNascimento, cpf, peso, altura);

int idade = p.CalcularIdade(); 

decimal imc = Math.Round(p.CalculaIMC(),2);

bool sair = false;

while (!sair)
{
    Console.WriteLine("Escolha uma das opções abaixo!");
    Console.WriteLine("0 - Informações dos usuário");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verifica a maioridade do usuário");
    Console.WriteLine("3 - Sair");

    string? opcao = Console.ReadLine();

switch (opcao) 
{
    case "0":
    Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
    Console.WriteLine($"Data de Nascimento: {dataNascimento}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"CPF: {cpf}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine ($"IMC: {imc}");
    break;

    case "1":
    Console.WriteLine($"Seu IMC é: {imc} ");
    if (imc < 17)
    {
        Console.WriteLine ($"Voce esta abaixo do peso, por ter {imc} de IMC");
    }else if (imc >=17 && imc <19)
    {
        Console.WriteLine ($"Voce esta abaixo do peso, por ter {imc} de IMC");
    }else if (imc >=19 && imc <25)
    {
        Console.WriteLine ($"Peso normal, por ter {imc} de IMC");
    }else if (imc >=25 && imc <30)
    {
        Console.WriteLine ($"Acima do peso, por ter {imc} de IMC");
    }else if (imc >=30 && imc <35)
    {
        Console.WriteLine ($"Obesidade grau 1, por ter {imc} de IMC");
    }else if (imc >=35 && imc <=40)
    {
        Console.WriteLine ($"Obesidade grau 2, por ter {imc} de IMC");
    }else if (imc > 40)
    {
        Console.WriteLine ($"Obesidade grau 3, por ter {imc} de IMC");
    }
    break;

    case "2":
    if(idade >= 18) //se
    {
        //fazer uma acao
        Console.WriteLine($"Ola {nome}, parabéns você ja é maior de idade");
    }else
    Console.WriteLine($"Ola {nome}, voce é Menor de idade por ter apenas {idade} anos de vida");
    break;

    case "3":
    sair = true;
    break;
}

}


