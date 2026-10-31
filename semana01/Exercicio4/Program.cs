using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        List<int> numeros = new List<int>();
        
            int novoNumero = 0;

        do
        {
            Console.Write("Insira um número ou 0 para sair: ");
            string numeroTexto = Console.ReadLine();
            novoNumero = int.Parse(numeroTexto);


            if (novoNumero != 0)
            {
                numeros.Add(novoNumero);
            }
           

        } while (novoNumero != 0);
        int somar = 0;
        double media = 0;
        
        foreach (int numero in numeros)
        {

            Console.WriteLine(numero);
            somar += numero;
            
            

        }
        media = (double)somar/numeros.Count;
        numeros.Sort();

        Console.WriteLine($"total de números da lista: {numeros.Count}");
        Console.WriteLine($"soma dos números da lista: {somar}");
        Console.WriteLine($"a média dos números é: {media}");
        Console.WriteLine($"o maior número da lista é: {numeros[numeros.Count -1]}");

    }
}