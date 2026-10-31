using System;

class Program
{
    static void Main(string[] args)
    {
        static void ExibirBoasVindas()
        {
            Console.WriteLine("bem vindo ao programa");
        }
    ExibirBoasVindas();
    string nomeUsuario = PerguntarNomeUsuario();
    int numeroFavorito = PerguntarNumeroFavorito();
    int resultado = ElevarAoQuadrado(numeroFavorito);

        

    static string PerguntarNomeUsuario()
        {
            Console.Write("por favor, Insira seu nome: ");
            string nome = Console.ReadLine();
            return nome;
        }
        

    static int PerguntarNumeroFavorito()
        {
            Console.Write("por favor, Insira seu número favorito: ");
            string numeroTexto = Console.ReadLine();
            int numero = int.Parse(numeroTexto);
            return numero;
        }

    static int ElevarAoQuadrado(int numero)
        {
            int resultado = numero * numero;
            return resultado;
        }

    static void ExibirResultado(string nome, double resultado)
        {
            Console.Write($"Irmão {nome}, o quadrado do seu número é {resultado}");
        }


        
        ExibirResultado(nomeUsuario,resultado);

    }
}