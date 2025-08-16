using System.Net.Http.Headers;
using System.Runtime.Serialization;
double idade = 0;
double media = 0;
int loop = -1;
double somas = 0;



while (idade >= 0)
{
    somas += idade;
    Console.WriteLine("Escreva a idade desejada: ");
    idade = Convert.ToInt32(Console.ReadLine()); 
    loop++;
   }

media = somas / loop;
Console.WriteLine($"A media das idades é {media}");
Console.WriteLine(loop);