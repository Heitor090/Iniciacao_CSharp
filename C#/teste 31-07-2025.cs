
// inteiro num

using System;

int idade = 0;
string nome = "x";
double num1 = 0;
double altura = 0;
DateTime data = DateTime.Now;


Console.WriteLine("Escreva seu nome");
nome = Console.ReadLine();

Console.WriteLine("Escreva seu altura");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreva sua idade");
    idade = int.Parse(Console.ReadLine());

if (idade <= 17)
{
    Console.WriteLine("Você é menor de idade");
}
else  (idade >= 19)
{
    Console.WriteLine("Você é maior de idade");
}
else if (idade <0)
{
    Console.Write("Idade invalida");

}


    Console.WriteLine($"Seu nome é: {nome} seja bem vindo, sua idade é: {idade}, e voce tem {altura} metros de altura ");