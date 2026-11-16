using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto MemorizadorEscrituras.");

       
        Referencia referencia = new Referencia("Éter", 12, 27);

        // 2. Criar o texto da escritura
        string texto = "E se os homens vierem a mim, mostrar-lhes-ei sua fraqueza.  " +
                       "E dou a fraqueza aos homens a fim de que sejam humildes; " +
                       " e minha graça basta a todos os que se humilham perante mim;" +
                       "porque caso se humilhem perante mim e tenham fé em mim," +
                       "então farei com que as coisas fracas se tornem fortes para eles.";

        Escritura escritura = new Escritura(referencia, texto);

        bool executando = true;

        
        while (executando)
        {
            Console.Clear();

            escritura.ExibirEscritura();

        
            if (escritura.TodasPalavrasOcultas())
            {
                Console.WriteLine("\nTodas as palavras foram ocultadas!");
                Console.WriteLine("Programa encerrado.");

                executando = false;
            }
            else
            {
                Console.WriteLine("\nPressione ENTER para continuar.");
                Console.WriteLine("Digite 'sair' para encerrar.");

                string entrada = Console.ReadLine();

                
                if (entrada.ToLower() == "sair")
                {
                    executando = false;
                }
            
                else if (string.IsNullOrEmpty(entrada))
                {
                    escritura.OcultarPalavrasAleatorias();
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.WriteLine("Pressione ENTER para continuar.");
                    Console.ReadLine();
                }
            }
        }
    }
}


    
