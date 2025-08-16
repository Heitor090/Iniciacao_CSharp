using System.Dynamic;

double C;
double F;

Console.WriteLine("Escreva a temperatuda, para descobrir em Fahrenheit: ");
C = Convert.ToDouble(Console.ReadLine());

F = C * 1.8 + 32;

Console.WriteLine($"A temperatura é de: {F}° Fahrenheit");
