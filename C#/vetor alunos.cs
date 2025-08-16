string[] alunos = new string[5];


 for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine($"Digite o nome do alunos {i + 1}: {alunos[i]}");
    alunos[i] = Convert.ToString( Console.ReadLine() );  

    
}
Console.Clear();


double[] medias = new double[5];

for (int i = 0;i < medias.Length;i++)
{

    Console.WriteLine($"Digite as notas dos alunos {i + 1}: {medias[i]}");
    medias[i] = Convert.ToDouble( Console.ReadLine() );
  
}
Console.Clear();
for (int i = 0; i < medias.Length ; i++)
{
    Console.WriteLine($"Nomes: {alunos[i]}; Medias: {medias[i]}");
}  