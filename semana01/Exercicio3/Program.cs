using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("Qual o número mágico? ");
        // string numeroEscrito = Console.ReadLine();
        // int numeroMagico = int.Parse(numeroEscrito);
        string resposta = "sim";
        while (resposta == "sim")
        {
            Random numeroEscrito = new Random();
            int numeroMagico = numeroEscrito.Next(1, 100);
            int numeroPalpite = 0;

            int contador = 0;

            while (numeroMagico != numeroPalpite)
            {
                Console.Write("Qual o seu palpite? ");
                string numeroSugerido = Console.ReadLine();
                numeroPalpite = int.Parse(numeroSugerido);

                contador++;
                if (numeroPalpite > numeroMagico)
                {
                    Console.WriteLine("menor");
                }
                else if (numeroPalpite < numeroMagico)
                {
                    Console.WriteLine("maior");
                }
                else
                {
                    Console.WriteLine("você acertou");
                    Console.WriteLine($"Total de tentativas: {contador}");
                    Console.WriteLine("deseja continuar sim ou não?  ");
                    resposta = Console.ReadLine();
                    if(resposta == "não")
                    {
                        Console.WriteLine("obrogado por jogar");
                    }
                    
                    
                }

                
            }
            
        }
        
    }



}
