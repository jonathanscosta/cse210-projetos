using System;
using System.Collections.Generic;

public class Diario
{
    private List<Registro> _entradas;

    public Diario()
    {
        _entradas = new List<Registro>();
    }

    public void AdicionarEntrada(Registro entrada)
    {
        _entradas.Add(entrada);
    }

    public void ExibirEntradas()
    {
        if (_entradas.Count == 0)
        {
            Console.WriteLine("Seu diário ainda está vazio.");
            return;
        }

        foreach (Registro entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public List<Registro> ObterEntradas()
    {
        return new List<Registro>(_entradas);
    }

    public void CarregarEntradas(List<Registro> entradas)
    {
        _entradas = new List<Registro>(entradas);
    }
}