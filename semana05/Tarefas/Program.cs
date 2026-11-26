using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto Tarefas.");

        TarefaDeMatematica tarefa1 = new TarefaDeMatematica("Jonathan", "matematica","7.3", "8 - 19");

        Console.WriteLine(tarefa1.ObterResumo());
        Console.WriteLine(tarefa1.ObterListaDeTarefas());
    }
}