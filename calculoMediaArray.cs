using System.Net.Http.Headers;

Console.Write("Digite o número de notas: ");
int numNotas = int.Parse(Console.ReadLine());

double [] notas = new double [numNotas];


for (int i = 0; i < numNotas; i++)
{
    Console.WriteLine($"Digite a nota {i+1}");
    notas[i] = double.Parse(Console.ReadLine());
}

double soma = 0;

for (int i = 0; i < notas.Length; i++)
{
    soma += notas[i];
}

double media = soma/numNotas;

Console.WriteLine("Sua media é: "+ media);
