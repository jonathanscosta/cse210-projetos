using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto MemorizadorEscrituras.");

        // 1. Criar a referência bíblica
        Referencia referencia = new Referencia("Éter", 12, 27);

        // 2. Criar o texto da escritura
        string texto = "E se os homens vierem a mim, mostrar-lhes-ei sua fraqueza.  " +
                       "E dou a fraqueza aos homens a fim de que sejam humildes; " +
                       " e minha graça basta a todos os que se humilham perante mim;" +
                       "porque caso se humilhem perante mim e tenham fé em mim," +
                       "então farei com que as coisas fracas se tornem fortes para eles.";

        // 3. Criar o objeto Escritura
        Escritura escritura = new Escritura(referencia, texto);

        bool executando = true;

        // 4. Loop principal do programa
        while (executando)
        {
            Console.Clear();

            // Exibir a referência e o texto
            escritura.ExibirEscritura();

            // 5. Verificar se todas as palavras estão ocultas
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

                // 6. Verificar se o usuário deseja sair
                if (entrada.ToLower() == "sair")
                {
                    executando = false;
                }
                // 7. Se pressionar Enter, ocultar palavras
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


    
