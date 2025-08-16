double altura;
int idade;



Console.WriteLine("Escreva seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Escreva sua idade: ");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Olá {nome}! Você tem {idade} anos e {altura} metros de altura.");
