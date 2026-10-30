using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("digite seu nome:" );
      string nome = Console.ReadLine();
      Console.Write("digite seu sobrenome:" );
      string sobrenome = Console.ReadLine();
      
      Console.WriteLine($"meu nome é {sobrenome}, {nome} {sobrenome}");

    }
}