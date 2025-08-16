

using System.Globalization;

Console.WriteLine("Escreva o nome do aluno: ");
string nome = Console.ReadLine(); ;

Console.WriteLine("Escreva a primeira nota do aluno: ");
double nota1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Escreva a segunda nota do aluno: ");
double nota2 = Convert.ToDouble(Console.ReadLine());



double media = (nota1 + nota2) / 2;
Console.WriteLine($"A media do aluno {nome} foi de {media}");
if (media >= 7)
{
    Console.WriteLine($"O aluno {nome}, esta aprovado");
}
else if (media >= 5)
{
    Console.WriteLine($"O aluno {nome}, esta de recuperação");
}
else
{
    Console.WriteLine("O aluno esta reprovado");
}

int convertido = (int)Math.Floor(media);


    switch (convertido)
    {
        case 10:
            Console.WriteLine("A classificação da media do aluno é A");
            break;
        case 9:
            Console.WriteLine("A classificação da media do aluno é A");
            break;
        case 8:
            Console.WriteLine("A classificação da media do aluno é B");
            break;
        case 7:
            Console.WriteLine("A classificação da media do aluno é C");
            break;
        case 6:
            Console.WriteLine("A classificação da media do aluno é D");
            break;
        case 5:
            Console.WriteLine("A classificação da media do aluno é D");
            break;
        case 4:
            Console.WriteLine("A classificação da media do aluno é F");
            break;
        case 3:
            Console.WriteLine("A classificação da media do aluno é F");
            break;
        case 2:
            Console.WriteLine("A classificação da media do aluno é F");
            break;
        case 1:
            Console.WriteLine("A classificação da media do aluno é F");
            break;


    }
