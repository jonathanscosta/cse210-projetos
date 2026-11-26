using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto Tarefas.");

        Tarefa tarefa1 = new Tarefa("Jonathan", "matematica");

        Console.WriteLine(tarefa1.ObterResumo());

        TarefaDeMatematica tarefa2 = new TarefaDeMatematica("Jonathan", "matematica", "7.3", "8 - 19");

        Console.WriteLine(tarefa2.ObterResumo());
        Console.WriteLine(tarefa2.ObterListaDeTarefas());

        TarefaDeRedacao tarefa3 = new TarefaDeRedacao("Jonathan", "As Brumas de Avalon", "redação");

        Console.WriteLine(tarefa3.ObterResumo());
        Console.WriteLine(tarefa3.ObterInformacoesDaRedacao());


    }
}

