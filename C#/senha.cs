
using System.Net.Mail;





string senha;
do
{

     Console.WriteLine("Digite sua senha: ");
     senha = Console.ReadLine();

    if (senha == "Corinthians")
    {
        Console.WriteLine("Bem vindo fiel!");
    }
    else
    {
       
        Console.WriteLine("Acesso Negado");
    }


} while (senha != "Corinthians");