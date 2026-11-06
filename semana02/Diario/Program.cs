
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();
        ArquivoDiario arquivo = new ArquivoDiario("diario.txt");

        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n========== MEU DIÁRIO ==========");
            Console.WriteLine("1 - Escrever uma nova entrada");
            Console.WriteLine("2 - Exibir todas as entradas");
            Console.WriteLine("3 - Salvar diário");
            Console.WriteLine("4 - Carregar diário");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("================================");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                string pergunta = gerador.ObterPerguntaAleatoria();

                Console.WriteLine($"\nPergunta: {pergunta}");

                Console.Write("\nSua resposta: ");
                string resposta = Console.ReadLine();

                string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                Registro novaEntrada = new Registro(data, pergunta, resposta);

                diario.AdicionarEntrada(novaEntrada);

                Console.WriteLine("\nEntrada adicionada ao diário!");
            }

            else if (opcao == "2")
            {
                diario.ExibirEntradas();
            }

            else if (opcao == "3")
            {
              
                    arquivo.Salvar(diario.ObterEntradas());
            }
              
            else if (opcao == "4")
            {
                    diario.CarregarEntradas(arquivo.Carregar());

                    Console.WriteLine("Diário carregado com sucesso!");
            }

            else if (opcao == "5")
            {
                Console.WriteLine("\nEncerrando o diário...");

                executando = false;
            }

            else
            {
                Console.WriteLine("\nOpção inválida! Tente novamente.");
            }
        }
    }
    }

