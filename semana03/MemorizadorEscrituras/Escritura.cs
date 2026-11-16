
using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private Random _random;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();
        _random = new Random();

        string[] palavrasSeparadas = texto.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string palavra in palavrasSeparadas)
        {
            Palavra novaPalavra = new Palavra(palavra);

            _palavras.Add(novaPalavra);
        }
    }

    public void ExibirEscritura()
    {
        Console.WriteLine(_referencia.ObterReferencia());

        foreach (Palavra palavra in _palavras)
        {
            Console.Write(palavra.ObterTexto() + " ");
        }

        Console.WriteLine();
    }

    public void OcultarPalavrasAleatorias()
    {
        List<Palavra> palavrasDisponiveis = new List<Palavra>();

        // Seleciona somente palavras que ainda não foram ocultadas
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                palavrasDisponiveis.Add(palavra);
            }
        }

        // Se não houver mais palavras disponíveis, encerra o método
        if (palavrasDisponiveis.Count == 0)
        {
            return;
        }

        // Escolhe entre 1 e 3 palavras para ocultar
        int quantidade = _random.Next(1, 4);

        if (quantidade > palavrasDisponiveis.Count)
        {
            quantidade = palavrasDisponiveis.Count;
        }

        for (int i = 0; i < quantidade; i++)
        {
            int indice = _random.Next(palavrasDisponiveis.Count);

            Palavra palavraEscolhida = palavrasDisponiveis[indice];

            palavraEscolhida.Ocultar();

            // Remove da lista para não selecionar novamente
            palavrasDisponiveis.RemoveAt(indice);
        }
    }

    public bool TodasPalavrasOcultas()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }
}
