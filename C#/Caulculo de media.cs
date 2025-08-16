



using System.Globalization;

Console.WriteLine("Escreva o nome do aluno: ");
string nome = Console.ReadLine(); ;

Console.WriteLine("Escreva a primeira nota do aluno: ");
double nota1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Escreva a segunda nota do aluno: ");
double nota2 = Convert.ToInt32(Console.ReadLine());


double media2 = 0;

media2 = (nota1 + nota2) / 2;
Console.WriteLine($"A media do aluno {nome} foi de {media2}");
if (media2 >= 7)
{
    Console.WriteLine($"O aluno {nome}, esta aprovado");
}
else if (media2 >= 5)
{
    Console.WriteLine($"O aluno {nome}, esta de recuperação");
}
else
{
    Console.WriteLine("O aluno esta reprovado");
}
double media = 0;
media = (media2 / 2) * 2;

if (media % 10 != 0)
{
    
    int nota3 = nota1;
    int nota4 = nota2;
    media = (nota3 + nota4) / 2;
    double numero = media;
  
    string numeroComoTexto = numero.ToString(CultureInfo.InvariantCulture);

    string entrada = numeroComoTexto;

    if (double.TryParse(entrada, NumberStyles.Any, new CultureInfo("pt-BR"), out double numero1))
    {
        if (numero1 >= 0 && numero1 <= 10)
        {
            int convertido = (int)Math.Floor(numero1);


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
        }
    }

}
