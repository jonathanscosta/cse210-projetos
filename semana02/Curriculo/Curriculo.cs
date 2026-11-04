using System;
using System.Collections.Generic;


public class Curriculo
{
    public string _nome = "";

    public List<Emprego> _empregos = new List<Emprego>();

    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Experiências profissionais");
        Console.WriteLine("");

        foreach(Emprego e in _empregos)
        {
            e.Exibir();
            Console.WriteLine("_____________");
        }
    }


}