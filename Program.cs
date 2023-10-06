using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorCSharp;
class Program
{
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      string[] operacoes = {"Soma", "Subtracao", "Divisao", "Multiplicacao", "Sair"};
      
      System.Console.WriteLine("Qual operação você deseja realizar?\nEscolha entre as 4 opções: Soma, Subtracao, Divisao e Multiplicacao");
      var escolhaUsuario = Console.ReadLine();

      if (!operacoes.Contains(escolhaUsuario))
      {
        System.Console.WriteLine("Escolha uma operação válida!");
        return;
      }
      else
      {
        switch(escolhaUsuario)
        {
          case "Soma": Soma(); break;
          case "Subtracao": Subtracao(); break;
          case "Divisao": Divisao(); break;   
          case "Multiplicacao": Multiplicacao(); break;
          case "Sair": System.Environment.Exit(0); break;
          default: Menu(); break;
        }
      }

    }
    static public void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1+v2;
      System.Console.WriteLine($"{v1} + {v2} = {result}");

      Menu();
    }

    static public void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1-v2;
      System.Console.WriteLine($"{v1} - {v2} = {result}");

      Menu();
    }

    static public void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1/v2;
      System.Console.WriteLine($"{v1} / {v2} = {result}");

      Menu();
    }

    static public void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      float result = v1 * v2;
      System.Console.WriteLine($"{v1} * {v2} = {result}");

      Menu();
    }
}