using System;

public class Registro
{
    private string _data;
    private string _pergunta;
    private string _resposta;

    // Construtor vazio para permitir carregar registros do JSON
    public Registro()
    {
        _data = "";
        _pergunta = "";
        _resposta = "";
    }

    public Registro(string data, string textoPergunta, string textoResposta)
    {
        _data = data;
        _pergunta = textoPergunta;
        _resposta = textoResposta;
    }

    public string Data
    {
        get { return _data; }
        set { _data = value; }
    }

    public string Pergunta
    {
        get { return _pergunta; }
        set { _pergunta = value; }
    }

    public string Resposta
    {
        get { return _resposta; }
        set { _resposta = value; }
    }

    public void Exibir()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_pergunta}");
        Console.WriteLine($"Resposta: {_resposta}");
        Console.WriteLine("------------------------------");
    }
}