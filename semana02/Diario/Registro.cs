using System;


public class Registro
{
    private string _data;
    private string _pergunta;
    private string _resposta;

    public Registro( string data, string textoPergunta, string textoResposta)
    {
        _data = data;
        _pergunta = textoPergunta;
        _resposta = textoResposta;
    }

    public string Data
    {
        get {return _data;}
    }
    public string Pergunta
    {
        get {return _pergunta;}
    }
    public string Resposta
    {
        get {return _resposta;}
    }

    public void Exibir()
    {
        Console.WriteLine("----------------");
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"{_pergunta}");
        Console.WriteLine($"{_resposta}");
        Console.WriteLine("----------------");
    }
}