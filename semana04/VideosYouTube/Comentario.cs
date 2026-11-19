using System;



public class Comentario
{
private string _nome;
private string _comentario;


public Comentario (string nome, string comentario)
    {
        _nome = nome;
        _comentario = comentario;
    }
    public string ObterComentario()
    {
        return $"{_nome}: {_comentario}";
    }
}