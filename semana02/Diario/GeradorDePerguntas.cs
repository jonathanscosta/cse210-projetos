using System;
using System.Collections.Generic;


public class GeradorDePerguntas
{
    private List<string> _perguntas;

    public GeradorDePerguntas()
    {
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
        Random random = new Random();
        int i = random.Next(_perguntas.Count);
        return _perguntas[i];
    }
}