using System;


public class Tarefa
{
    protected string _nomeEstudante;
    private string _topico;


    public Tarefa(string nomeEstudante, string topico)
    {
        _nomeEstudante = nomeEstudante;
        _topico = topico;
    }

    public string ObterResumo()
    {
        return $"nome: {_nomeEstudante} - tópico {_topico}";
    }

}