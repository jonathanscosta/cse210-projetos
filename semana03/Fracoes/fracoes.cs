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
     public string ExibirFracoes()
    {
        return $"{_numerador}/{_denominador}";
    }
    public Fracoes(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
      
    }
    
   
}