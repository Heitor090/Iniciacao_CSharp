double altura = 0;
double peso = 0;

Console.Write("Escreva seu peso: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Escreva sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());




Console.WriteLine($"Seu indice de massa corporal é {peso / (altura * altura):F}");
