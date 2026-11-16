using System;

public class Palavra
{
    private string _texto;
    private bool _oculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _oculta = false;
    }

    public void Ocultar()
    {
        _oculta = true;
    }

    public string ObterTexto()
    {
        if (_oculta)
        {
            return "_____";
        }
        else
        {
            return _texto;
        }
    }

    public bool EstaOculta()
    {
        return _oculta;
    }
}
