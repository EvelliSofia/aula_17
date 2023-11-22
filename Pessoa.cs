using System; 

public class Pessoa

//Atributos 

{
public string? Nome; 
public string? Sobrenome; 
public DateTime DataNascimento;
public int CPF; 
public decimal Peso;
public decimal Altura;

//Construtor
public Pessoa (string? nome, string? sobrenome, DateTime dataNascimento, int cpf, decimal peso, decimal altura )

{
    Nome = nome; 
    Sobrenome = sobrenome; 
    DataNascimento = dataNascimento;
    CPF = cpf;
    Peso = peso; 
    Altura = altura;
}

//Metodos 

public int CalcularIdade()
{
    DateTime dataAtual = DateTime.Now;
    int idade = dataAtual.Year - DataNascimento.Year;
    return idade;
}

public decimal CalculaIMC()
{
    decimal peso = (decimal)Peso; 
    decimal altura = Altura;

    decimal imc = peso / (altura * altura);

    return imc; 
}



}