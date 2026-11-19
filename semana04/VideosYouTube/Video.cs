using System;
using System.Collections.Generic;



public class Video
{
    private string _titulo;
    private string _autor;
    private double _duracao;

    private List<Comentario> _comentarios = new List<Comentario>();


    public Video (string titulo, string autor, double duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
    }
    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }
    public int NumeroComentario()
    {
        return _comentarios.Count;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titulo: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracao} segundos");
        Console.WriteLine($"Número de comentarios: {NumeroComentario()}");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine(comentario.ObterComentario());
        }
    }

}