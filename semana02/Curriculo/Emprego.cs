using System;
using System.Collections.Generic;


public class Emprego
{
    public string _empresa;
    public string _cargo;
    public int _anoInicio;
    public int _anoFim;

    public void Exibir()
    {
        
        Console.WriteLine($"Cargo: {_cargo}, ");
        Console.WriteLine($"({_empresa}) ");
        Console.WriteLine($"{_anoInicio} - {_anoFim}");
    }
}