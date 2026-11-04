using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto Diario.");
        Pessoa pessoa = new Pessoa();
        pessoa.__PrimeiroNome = "Joseph";
        pessoa.__SegundoNome = "Smith";

        pessoa.ObterNomeSobrenome();
        pessoa.ObterSobrenomeNome();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.__PrimeiroNome = "Emma";
        pessoa1.__SegundoNome = "Smith";

        pessoa1.ObterNomeSobrenome();

        Persianas cozinha = new Persianas();

        cozinha.__altura = 60;
        cozinha.__largura = 48;

        double ValorMaterial = cozinha.ObterArea();

        Console.WriteLine($"a área do materia é {ValorMaterial}");


    }
public class Pessoa
    {
        public string __PrimeiroNome = "";
        public string __SegundoNome = "";

        public Pessoa()
        {
            
        }
        public void ObterNomeSobrenome()
        {
            Console.WriteLine($"{__PrimeiroNome} {__SegundoNome}");
        }
        public void ObterSobrenomeNome()
        {
            Console.WriteLine($"{__SegundoNome}, {__PrimeiroNome}");
        }
      
    }

public class Persianas
    {

        public double __largura;
        public double __altura;
        public string __cor;

        public double ObterArea()
        {
            return __altura * __largura;
        }
        public Persianas()
        {
            
        }
    }
       


}