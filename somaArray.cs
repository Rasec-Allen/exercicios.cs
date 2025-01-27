using System;

public class somaArray
{
    public static void Main(string[] args)
    {
      int soma = 0;
        
      Console.WriteLine("Insira quantos números vão ser inseridos:");
      int quantidade = Convert.ToInt32(Console.ReadLine());
      
      int[] numeros = new int [quantidade];
      
      for (int i = 0; i < numeros.Length; i++)
      {
          Console.Write("Insira o número "+ (i+1) + ":");
          numeros[i]= Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("Os números do array são: ");
      for (int i = 0; i < numeros.Length; i++)
      {
          Console.WriteLine(numeros[i]);
      }
      
      for (int i = 0; i < quantidade; i++)
      {
          soma +=numeros[i];
      }
      
      Console.WriteLine("A soma dos números inseridos é: " + soma);
    }
