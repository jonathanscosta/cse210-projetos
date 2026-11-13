using System;


public class Fracoes
{
    private int _numerador;
    private int _denominador;

    public Fracoes()
    {
        _numerador = 1;
        _denominador = 1;
      
    }
    public Fracoes(int numNumerador)
    {
        _numerador = numNumerador;
        _denominador = 1;
      
    }
    public Fracoes(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
      
    }
    public string ObterFracaoEmTexto()
    {
        string fracaoTexto = $"{_numerador}/{_denominador}";
        return fracaoTexto;
    }

    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / (double)_denominador;
    }
    
     public string ExibirFracoes()
    {
        return $"{_numerador}/{_denominador}";
    }
   
}