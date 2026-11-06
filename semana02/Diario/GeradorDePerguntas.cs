using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    private List<string> _perguntas;
    private Random _random;

    public GeradorDePerguntas()
    {
        _random = new Random();

        _perguntas = new List<string>
        {
            "O que me fez feliz hoje?",
            "Qual foi meu maior desafio hoje?",
            "O que aprendi de novo?",
            "Pelo que sou grato hoje?",
            "O que posso melhorar amanhã?",
            "Qual foi minha maior conquista?",
            "Como posso ajudar alguém amanhã?",
            "O que quero lembrar deste dia?"
        };
    }

    public string ObterPerguntaAleatoria()
    {
        int indice = _random.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}