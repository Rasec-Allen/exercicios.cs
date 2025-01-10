internal class listaDeChamada
{
    private static void Main(string[] args)
    {
          Console.Write("Digite o número de alunos: ");

         int quantidade = Convert.ToInt32(Console.ReadLine());

        string[] alunos = new string[quantidade];

        for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = Console.ReadLine();
            }

        Array.Sort(alunos);

        Console.WriteLine("\nAlunos em ordem alfabética: ");

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine(alunos[i]);
        }  
    }
}
