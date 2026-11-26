using System;


public class TarefaDeRedacao : Tarefa
{
    private string _titulo;

    public TarefaDeRedacao( string nomeEstudante, string titulo, string topico) : base (nomeEstudante, topico)
    {
        _titulo = titulo;
    }

    public string ObterInformacoesDaRedacao()
    {
        return $"{_titulo}, por {_nomeEstudante}";
    }


}